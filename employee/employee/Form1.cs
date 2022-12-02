
using System.Data;
using System.Data.SqlClient;

namespace employee
{
    public partial class Form1 : Form
    {/*
        private SqlConnection con = new SqlConnection(@"Data Source = SANDIPSHRESDC60\SQLEXPRESS;
                                                Initial Catalog=empl_details;
                                                Integrated Security=True");
        */
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TSU4EHG\SQLEXPRESS;
                                                Initial Catalog=empl_details;
                                                user id=sa;password=kist@123;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            con.Open();
            string query = "Insert into employee values('"+ txtUserName.Text
                +"','"+ txtUserAddr.Text +"','"+ txtUserSalary.Text +"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
            */
            con.Open();
            string query = "Insert into employee " + "(name,address,salary)" + "values (@txtUserName,@txtUserAddr,@txtUserSalary)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", txtUserName.Text);
            cmd.Parameters.AddWithValue("@address", txtUserAddr.Text);
            cmd.Parameters.AddWithValue("@salary", txtUserSalary.Text);

            cmd.ExecuteNonQuery();
            con.Close();



        }

        private void displayData_Click(object sender, EventArgs e)
        {   /*
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-TSU4EHG\SQLEXPRESS;
                                                Initial Catalog=empl_details;
                                                user id=sa;password=kist@123;");

            con.Open();

            string Query = "select * from employee";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();
            */
            try
            {
                string query = "Select * from employee";
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                // dataGridView1.DataSource = dt;
                int sn = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["column1"].ToString();
                    string name = dt.Rows[i]["column2"].ToString();
                    string address = dt.Rows[i]["column3"].ToString();
                    string salary = dt.Rows[i]["column4"].ToString();
                    dataGridView1.Rows.Add(sn++, id, name, address, salary);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.InnerException);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
           
            string query = "update employee set name='" + txtUserName.Text +"', address='"+ txtUserAddr.Text +"' ,salary ='"+ txtUserSalary.Text +"' where emp_id = '"+ txtUserID.Text +"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from employee where id = '"+ txtUserID.Text +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete successfully");
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into student " + "(name,address,salary)" + "values(@name,@address,@salary)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", txtUserName.Text);
            cmd.Parameters.AddWithValue("@address", txtUserAddr.Text);
            cmd.Parameters.AddWithValue("@salary", txtUserSalary.Text);

            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}