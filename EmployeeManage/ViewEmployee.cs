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
    public partial class ViewEmployee: Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nidhi\OneDrive\Documents\Myemployee.db.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchempdata()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeTbl  WHERE EmpId='" + empidsearch.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                empidlbl.Text = dr["EmpId"].ToString();
                empnamelbl.Text = dr["EmpName"].ToString();
                empaddlbl.Text = dr["EmpAdd"].ToString();
                empposlbl.Text = dr["EmpPos"].ToString();
                empdoblbl.Text = dr["EmpDOB"].ToString();
                empidlbl.Visible = true;
                empnamelbl.Visible = true;
                empaddlbl.Visible = true;
                empposlbl.Visible = true;
                empdoblbl.Visible = true;
            }
            con.Close();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void emprefresh_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emphomelbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void empidsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void empprint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Employee Details", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(250, 50));
            e.Graphics.DrawString("Employee ID: " + empidlbl.Text, new Font("Arial", 14), Brushes.Black, new Point(100, 150));
            e.Graphics.DrawString("Employee Name: " + empnamelbl.Text, new Font("Arial", 14), Brushes.Black, new Point(100, 200));
            e.Graphics.DrawString("Employee Address: " + empaddlbl.Text, new Font("Arial", 14), Brushes.Black, new Point(100, 250));
            e.Graphics.DrawString("Employee Position: " + empposlbl.Text, new Font("Arial", 14), Brushes.Black, new Point(100, 300));
            e.Graphics.DrawString("Employee DOB: " + empdoblbl.Text, new Font("Arial", 14), Brushes.Black, new Point(100, 350));
            e.Graphics.DrawString("Thank you for using our service!", new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(100, 400));

        }
    }
}
