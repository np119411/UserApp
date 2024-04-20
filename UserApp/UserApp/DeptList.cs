﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApp
{
    public partial class DeptList : Form
    {
        public DeptList()
        {
            InitializeComponent();
        }

        private void DeptList_Load(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            string stringcmd = "SELECT departmentId, dName FROM Department";
            SqlCommand command = new SqlCommand(stringcmd, connection);

            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            DeptGridView.DataSource = dt;

            DeptGridView.Columns[0].HeaderCell.Value = "Department ID";
            DeptGridView.Columns[1].HeaderCell.Value = "Department Name";


            DeptGridView.ReadOnly = true;
            DeptGridView.AllowUserToAddRows = false;
            DeptGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeptList_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "DanhSachBoPhan.xls";
                savefile.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn column in DeptGridView.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                foreach (DataGridViewRow row in DeptGridView.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                    }
                }

                if (dt.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            wr.Write(dt.Columns[i].ToString() + "\t");
                        }

                        wr.WriteLine();

                        for (int i = 0; i < (dt.Rows.Count); i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                if (dt.Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dt.Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            wr.WriteLine();
                        }
                        wr.Close();
                        MessageBox.Show("Lưu hoàn tất!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Danh sách rỗng, kiểm tra lại danh sách!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
