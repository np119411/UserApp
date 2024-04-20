using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserApp
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void bttracuu_Click(object sender, EventArgs e)
        {

            string uIdCmd = uid.Text;

            string stringcmd;

            // Tìm bằng ID trước
            stringcmd = "SELECT uName, dId, dName FROM Employees WHERE uId = @uIdCmd";


            if ((uIdCmd == "" || uIdCmd == null))
            {
                MessageBox.Show("Hãy nhập User ID!", "Thông Báo");
            }
            else
            {
                try
                {
                    string connectionString;
                    connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

                    SqlConnection connection;
                    connection = new SqlConnection(connectionString);

                    SqlCommand command = new SqlCommand(stringcmd, connection);
                    command.Parameters.AddWithValue("@uIdCmd", uIdCmd);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        uname.Text = reader["uName"].ToString();
                        did.Text = reader["dId"].ToString();
                        dname.Text = reader["dName"].ToString();

                        reader.Close();
                        connection.Close();
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        MessageBox.Show("Không tìm thấy User với ID: " + uIdCmd, "Thông Báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR DATA", "Thông Báo");
                }
            }

        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            did.Items.Clear();
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            connection.Open();

            string sqlQuery = "SELECT departmentId FROM Department";

            SqlCommand command = new SqlCommand(sqlQuery, connection);


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string item = reader.GetString(0);
                did.Items.Add(item);

            }
            reader.Close();
            connection.Close();

            if (did.Text == null || did.Text == "")
            {
                dname.ReadOnly = false;
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dname.ReadOnly = false;
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            uid.Text = null;
            uname.Text = null;
            did.Text = null;
            dname.Text = null;

            did.Items.Clear();

            connection.Open();

            string sqlQuery = "SELECT departmentId FROM Department";

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string item = reader.GetString(0);
                did.Items.Add(item);

            }
            reader.Close();
            connection.Close();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            string uIdCmd = uid.Text;
            string uNameCmd = uname.Text;
            string uDIdCmd = did.Text;
            string uDNameCmd = dname.Text;

            if ((uIdCmd == "" || uIdCmd == null))
            {
                MessageBox.Show("Hãy nhập User ID!", "Thông Báo");
            }
            else if (uNameCmd == "" || uNameCmd == null)
            {
                MessageBox.Show("Hãy nhập User Name!", "Thông Báo");
            }
            else if (uDIdCmd == "" || uDIdCmd == null)
            {
                MessageBox.Show("Hãy nhập Bộ Phận!", "Thông Báo");
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO Employees VALUES(@uIdCmd, @uNameCmd, @uDIdCmd, @uDNameCmd)", connection);

                try
                {
                    command.Parameters.Add("@uIdCmd", SqlDbType.VarChar).Value = uIdCmd;
                    command.Parameters.Add("@uNameCmd", SqlDbType.NVarChar).Value = uNameCmd;
                    command.Parameters.Add("@uDIdCmd", SqlDbType.VarChar).Value = uDIdCmd.ToUpper();
                    command.Parameters.Add("@uDNameCmd", SqlDbType.NVarChar).Value = uDNameCmd;

                    connection.Open();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Add New Succesfully!", "Thông Báo");
                        connection.Close();
                        uid.Text = null;
                        uname.Text = null;
                        did.Text = null;
                        dname.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại! Hãy kiểm tra lại thông tin nhập!", "Thông Báo");
                        connection.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("User ID " + uid.Text + " đã tồn tại!", "Thông Báo");
                }
            }


        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)

        {
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
                    MessageBox.Show("Không có bộ phận này!", "Thông Báo");
                    reader.Close();
                    connection.Close();
                    did.Text = null;
                    dname.Text = null;
                }
            }
            if (did.Text == null || did.Text == "")
            {
                dname.ReadOnly = false;
            }
        }




        private void did_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                reader.Close();
                connection.Close();
                dname.ReadOnly = true;
            }
            reader.Close();
            connection.Close();

            if (did.Text == null || did.Text == "")
            {
                dname.ReadOnly = false;
            }

        }




        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttaddbp_Click(object sender, EventArgs e)
        {
            AddDepartment add = new AddDepartment();
            add.Show();
        }

        private void uid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dname_TextChanged(object sender, EventArgs e)
        {

        }


        private void did_MouseClick(object sender, MouseEventArgs e)

        {
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
            else if (did.Text == "" || did.Text == null)
            {

            }
            else
            {
                MessageBox.Show("Không có bộ phận này!", "Thông Báo");
                did.Text = null;
                dname.Text = null;
                reader.Close();
                connection.Close();
            }



        }

        private void CheckTabKeyPress(object sender, KeyEventArgs e)

        {
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
                    MessageBox.Show("Không có bộ phận này!", "Thông Báo");

                    did.Text = null;
                    dname.Text = null;
                    reader.Close();
                    connection.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString;
            connectionString = "Server=localhost\\SQLEXPRESS01;Database=NP119411;Trusted_Connection=True;";

            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            string uIdCmd = uid.Text;

            if ((uIdCmd == "" || uIdCmd == null))
            {
                MessageBox.Show("Hãy nhập User ID!", "Thông Báo");
            }

            else
            {
                string stringcmd = "Delete Employees WHERE uId = @uIdCmd";

                try
                {

                    SqlCommand command = new SqlCommand(stringcmd, connection);
                    command.Parameters.AddWithValue("@uIdCmd", uIdCmd);

                    connection.Open();


                    if (command.ExecuteNonQuery() == 1)

                    {
                        if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MessageBox.Show("Xóa hoàn tất!", "Thông Báo");
                            connection.Close();
                            uid.Text = null;
                            uname.Text = null;
                            did.Text = null;
                            dname.Text = null;
                        }
                    }
                    else
                    {

                        connection.Close();
                        MessageBox.Show("Không tồn tại User với ID: " + uIdCmd, "Thông Báo");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR DATA", "Thông Báo");
                }
            }

        }

        private void ListNV_Click(object sender, EventArgs e)
        {
            ListNV list = new ListNV();
            list.Show();
        }
    }
}
