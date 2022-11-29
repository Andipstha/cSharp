using System.Data.SqlClient;

namespace Calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operate;
        decimal calculation = 0;


        SqlConnection  con = new SqlConnection(@"Data Source = DESKTOP-TSU4EHG\SQLEXPRESS;
                                                Initial Catalog=bit3rdsem;
                                                user id=sa;password=kist@123;");



        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "1";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "1";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "2";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "3";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "4";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "5";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "6";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "7";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                textBox1.Text += "8";
            }
            else
            {
                string data = textBox1.Text;
                textBox1.Text = data + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            GetResultValue();
            //calculator = Convert.ToDecimal(textBox1.Text);
            operate = "x";
            textBox1.Text = textBox1.Text + "x";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "+";
            textBox1.Text = textBox1.Text + "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "-";
            textBox1.Text = textBox1.Text + "-";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "/";
            textBox1.Text = textBox1.Text + "/";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            GetResultValue();
            operate = "%";
            textBox1.Text = "%";
        }
        

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            decimal firstNum = calculation;
            decimal secondNum = Convert.ToDecimal(textBox1.Text);
            switch(operate)
            {
                case "-":
                    calculation = (firstNum - secondNum);
                    textBox1.Text = (firstNum - secondNum).ToString();
                    
                    break;
                case "+":
                    calculation = (firstNum + secondNum);
                    textBox1.Text = (firstNum + secondNum).ToString();
                    break;
                case "*":
                    calculation = (firstNum * secondNum);
                    textBox1.Text = (firstNum * secondNum).ToString();
                    break;
                case "/":
                    calculation = (firstNum / secondNum);
                    textBox1.Text = (firstNum / secondNum).ToString();
                    break;
                case "%":
                    calculation = (firstNum % secondNum);
                    textBox1.Text = (firstNum % secondNum).ToString();
                    break;
            }
        }

        public void GetResultValue()
        {
            if (textBox1.Text != "" && textBox1.Text != "+" && textBox1.Text != "-" && textBox1.Text != "*" && textBox1.Text != "/")
            {
                calculation = Convert.ToDecimal(textBox1.Text);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Student values('sandip','samakhushi','98476767','NIST')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update Student set name='Sandip', address='Kathmandu' ,contact ='9852145254',college='KIST' where id = 6";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();



                MessageBox.Show("Update Successfully");
                con.Close();

            }
           catch (Exception ex)
            {
                MessageBox.Show("Update Failed!");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Student where id = 6";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();



                MessageBox.Show("Removed Successfully");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Removed Failed!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Student";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();



                MessageBox.Show("Update Successfully");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed!");
            }
        }
    }
}