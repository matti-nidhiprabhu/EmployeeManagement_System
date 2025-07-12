using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmployeeManage
{
    public partial class Employee: Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nidhi\OneDrive\Documents\Myemployee.db.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(empid.Text==""||empname.Text==""||empadd.Text=="")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO EmployeeTbl VALUES('" + empid.Text + "','" + empname.Text + "','" + empadd.Text + "','" + emppos.SelectedItem.ToString() + "','" + empdob.Value.Date+ "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully");
                    con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empdgv.DataSource = ds.Tables[0];
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void empdeletebtn_Click(object sender, EventArgs e)
        {

        }

        private void empdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empeditbtn_Click(object sender, EventArgs e)
        {

        }

        private void emphomebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void empeditbtn_Click_1(object sender, EventArgs e)
        {
            if(empid.Text == "" || empname.Text == "" || empadd.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE EmployeeTbl SET EmpName='" + empname.Text + "',EmpAdd='" + empadd.Text + "',EmpPos='" + emppos.SelectedItem.ToString() + "',EmpDOB='" + empdob.Value.Date + "' WHERE EmpId='" + empid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void empdgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empdeletebtn_Click_1(object sender, EventArgs e)
        {
            if(empid.Text == "")
            {
                MessageBox.Show("Please enter Employee ID to delete");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM EmployeeTbl WHERE EmpId='" + empid.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void emphomebtn_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
