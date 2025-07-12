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
    public partial class Salary: Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nidhi\OneDrive\Documents\Myemployee.db.mdf;Integrated Security=True;Connect Timeout=30");


        private void emphomebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int DailyBase,total;
        private void empeditbtn_Click(object sender, EventArgs e)
        {
            if(emppostb.Text =="")
            {
                MessageBox.Show("Please fill all fields");
            }
            else if(workeddaystb.Text==""||Convert.ToInt32(workeddaystb.Text) >28)
            {
                MessageBox.Show("Please enter valid worked days (1-28)");
            }
            else
            {
                if(emppostb.Text == "Assistant Manager")
                {
                    DailyBase = 1000;
                }
                else if (emppostb.Text == "Senior Developer")
                {
                    DailyBase = 800;
                }
                else if (emppostb.Text == "Junior Developer")
                {
                    DailyBase = 600;
                }
                else
                {
                    DailyBase = 400;
                }
                total=DailyBase * Convert.ToInt32(workeddaystb.Text);
                salaryslip.Rows.Clear();
                salaryslip.Columns.Clear();

                // Define columns
                salaryslip.Columns.Add("Field", "Field");
                salaryslip.Columns.Add("Value", "Value");

                // Add salary data as rows
                salaryslip.Rows.Add("Employee ID", empidtb.Text);
                salaryslip.Rows.Add("Employee Name", empnametb.Text);
                salaryslip.Rows.Add("Position", emppostb.Text);
                salaryslip.Rows.Add("Worked Days", workeddaystb.Text);
                salaryslip.Rows.Add("Daily Base Salary", DailyBase.ToString());
                salaryslip.Rows.Add("Total Salary", total.ToString());

            }

        }
        private void fetchempdata()
        {
            if (empidtb.Text == "")
            {
                MessageBox.Show("Please enter Employee ID to search");

            }
            else
            { 
                    con.Open();
                string query = "SELECT * FROM EmployeeTbl  WHERE EmpId='" + empidtb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    empidtb.Text = dr["EmpId"].ToString();
                    empnametb.Text = dr["EmpName"].ToString();
                    empaddtb.Text = dr["EmpAdd"].ToString();
                    emppostb.Text = dr["EmpPos"].ToString();
                    

                }
                con.Close();
            }
        }

        private void Empaddbtn_Click(object sender, EventArgs e)
        {
            if(printPD.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12, FontStyle.Regular);
            float y = 100; // starting Y position
            float x = 100; // X position

            // Title
            e.Graphics.DrawString("Salary Slip", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x, y);
            y += 40;

            // Loop through DataGridView rows
            foreach (DataGridViewRow row in salaryslip.Rows)
            {
                if (row.IsNewRow) continue; // skip the empty new row at bottom

                string field = row.Cells[0].Value?.ToString();
                string value = row.Cells[1].Value?.ToString();

                string line = $"{field}: {value}";
                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += 30;
            }

            // Footer message
            y += 20;
            e.Graphics.DrawString("Thank you for your hard work!", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, x, y);
        }


        private void salaryslip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empdeletebtn_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
    }
}
