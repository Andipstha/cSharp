
using System.Data;
using System.Data.SqlClient;

namespace employee
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = SANDIPSHRESDC60\SQLEXPRESS;
                                                Initial Catalog=empl_details;
                                                Integrated Security=True");

        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into employee values('"+ txtUserName.Text
                +"','"+ txtUserAddr.Text +"','"+ txtUserSalary.Text +"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void displayData_Click(object sender, EventArgs e)
        {
            string ConnectionString = (@"Data Source = SANDIPSHRESDC60\SQLEXPRESS;
                                                Initial Catalog=empl_details;
                                                Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "select * from employee";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;

            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
           
            string query = "update Student set name='"+ txtUserName.Text +"', address='"+ txtUserAddr.Text +"' ,salary ='"+ txtUserSalary.Text +"', where id = '"+ txtUserID.Text +"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "delete from Student where id = '"+ txtUserID.Text +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }
    }
}