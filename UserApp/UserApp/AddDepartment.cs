using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UserApp
{
    public partial class AddDepartment : Form
    {

        public AddDepartment()
        {
            InitializeComponent();
        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            string didcmd = did.Text;

            string stringcmd = "SELECT dName FROM Department WHERE departmentId = @didcmd";
            if ((didcmd == "" || didcmd == null))
            {
                MessageBox.Show("Hãy nhập Mã Bộ Phận!", "Thông Báo");
            }
            else 
            {
                try
                {
                    SqlCommand command = new SqlCommand(stringcmd, connection);
                    command.Parameters.AddWithValue("@didcmd", didcmd);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        dname.Text = reader["dName"].ToString();

                        reader.Close();
                        connection.Close();
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        MessageBox.Show("Không tìm thấy Bộ Phận: " + didcmd, "Thông Báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR DATA", "Thông Báo");
                }
            }
                
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrefresh_Click(object sender, EventArgs e)
        {
            dname.ReadOnly = false;
            did.Text = null;
            dname.Text = null;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            string uDIdCmd = did.Text;
            string uDNameCmd = dname.Text;


            if (uDIdCmd == "" || uDIdCmd == null)
            {
                MessageBox.Show("Hãy nhập Bộ Phận!", "Thông Báo");
            }
            else if (uDNameCmd == "" || uDNameCmd == null)
            {
                MessageBox.Show("Hãy nhập Tên Bộ Phận!", "Thông Báo");
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO Department VALUES(@uDIdCmd, @uDNameCmd)", connection);
                try
                {
                    command.Parameters.Add("@uDIdCmd", SqlDbType.VarChar).Value = uDIdCmd;
                    command.Parameters.Add("@uDNameCmd", SqlDbType.NVarChar).Value = uDNameCmd;

                    connection.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Thêm hoàn tất!", "Thông Báo");
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại! Hãy kiểm tra lại thông tin đã nhập", "Thông Báo");
                        connection.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bộ Phận " + did.Text + " đã tồn tại!", "Thông Báo");
                }
            }
        }

        private void redep_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            string uDIdCmd = did.Text;
            string uDNameCmd = dname.Text;


            if ((uDIdCmd == "" || uDIdCmd == null))
            {
                MessageBox.Show("Hãy nhập Mã bộ phận!", "Thông Báo");
            }
            else
            {
                string stringcmd = "Delete Department WHERE departmentId = @didcmd";

                try
                {
                    SqlCommand command = new SqlCommand(stringcmd, connection);

                    command.Parameters.AddWithValue("@didcmd", did.Text);

                    connection.Open();

                    if (command.ExecuteNonQuery() == 1)

                    {
                        if (MessageBox.Show("Bạn có muốn xóa Bộ Phận này không?", "Xóa Bộ Phận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Xóa hoàn tất!", "Thông Báo");
                            connection.Close();
                            did.Text = null;
                            dname.Text = null;
                        }
                    }
                    else
                    {
                        connection.Close();
                        MessageBox.Show("Không tồn tại Bộ Phận: " + uDIdCmd, "Thông Báo");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Tồn tại Nhân Viên thuộc Bộ Phận này!", "Thông Báo");
                }
            }
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {

        }

        private void ListDept_Click(object sender, EventArgs e)
        {
            DeptList d = new DeptList();
            d.Show();
        }

        private void dname_TextChanged(object sender, EventArgs e)
        {

        }

        private void did_TextChanged(object sender, EventArgs e)
        {

        }
        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)

        {
            dname.ReadOnly = false;
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            string dIdCmd = did.Text;

            string stringcmd = "SELECT dName FROM Department WHERE departmentId = @dIdCmd";

            SqlCommand command = new SqlCommand(stringcmd, connection);
            command.Parameters.AddWithValue("@dIdCmd", dIdCmd);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (e.KeyChar == (char)Keys.Enter)

            {
                if (reader.Read())
                {
                    dname.Text = reader["dName"].ToString();
                    reader.Close();
                    connection.Close();
                    dname.ReadOnly = true;

                }
                else
                {
                    reader.Close();
                    connection.Close();

                }
            }
        }

        private void did_MouseClick(object sender, MouseEventArgs e)

        {
            dname.ReadOnly=false;
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            string dIdCmd = did.Text;

            string stringcmd = "SELECT dName FROM Department WHERE departmentId = @dIdCmd";

            SqlCommand command = new SqlCommand(stringcmd, connection);
            command.Parameters.AddWithValue("@dIdCmd", dIdCmd);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                dname.Text = reader["dName"].ToString();
                dname.ReadOnly = true;
                reader.Close();
                connection.Close();

            }
            else
            {
                reader.Close();
                connection.Close();
            }

        }
        private void CheckTabKeyPress(object sender, KeyEventArgs e)

        {
            dname.ReadOnly = false;
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            string dIdCmd = did.Text;

            string stringcmd = "SELECT dName FROM Department WHERE departmentId = @dIdCmd";

            SqlCommand command = new SqlCommand(stringcmd, connection);
            command.Parameters.AddWithValue("@dIdCmd", dIdCmd);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (e.KeyCode == Keys.Tab)

            {
                if (reader.Read())
                {
                    dname.Text = reader["dName"].ToString();
                    dname.ReadOnly = true;
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    reader.Close();
                    connection.Close();
                }
            }

        }
    }
}
