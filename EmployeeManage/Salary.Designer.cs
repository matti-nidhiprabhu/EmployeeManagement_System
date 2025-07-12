namespace EmployeeManage
{
    partial class Salary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salaryslip = new Guna.UI2.WinForms.Guna2DataGridView();
            this.emphomebtn = new System.Windows.Forms.Button();
            this.empdeletebtn = new System.Windows.Forms.Button();
            this.empeditbtn = new System.Windows.Forms.Button();
            this.empaddtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empnametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empidtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emppostb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workeddaystb = new Guna.UI2.WinForms.Guna2TextBox();
            this.printPD = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryslip)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Solid Edge Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.workeddaystb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.emppostb);
            this.panel1.Controls.Add(this.salaryslip);
            this.panel1.Controls.Add(this.empdeletebtn);
            this.panel1.Controls.Add(this.empeditbtn);
            this.panel1.Controls.Add(this.empaddtb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.empnametb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.empidtb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 480);
            this.panel1.TabIndex = 6;
            // 
            // salaryslip
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.salaryslip.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.salaryslip.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryslip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.salaryslip.ColumnHeadersHeight = 4;
            this.salaryslip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salaryslip.DefaultCellStyle = dataGridViewCellStyle6;
            this.salaryslip.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.salaryslip.Location = new System.Drawing.Point(573, 34);
            this.salaryslip.Name = "salaryslip";
            this.salaryslip.RowHeadersVisible = false;
            this.salaryslip.RowHeadersWidth = 51;
            this.salaryslip.RowTemplate.Height = 24;
            this.salaryslip.Size = new System.Drawing.Size(544, 277);
            this.salaryslip.TabIndex = 28;
            this.salaryslip.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.salaryslip.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.salaryslip.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.salaryslip.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.salaryslip.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.salaryslip.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.salaryslip.ThemeStyle.BackColor = System.Drawing.Color.MistyRose;
            this.salaryslip.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.salaryslip.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.salaryslip.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salaryslip.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryslip.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salaryslip.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salaryslip.ThemeStyle.HeaderStyle.Height = 4;
            this.salaryslip.ThemeStyle.ReadOnly = false;
            this.salaryslip.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.salaryslip.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salaryslip.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryslip.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.salaryslip.ThemeStyle.RowsStyle.Height = 24;
            this.salaryslip.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.salaryslip.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.salaryslip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salaryslip_CellContentClick);
            // 
            // emphomebtn
            // 
            this.emphomebtn.BackColor = System.Drawing.Color.MistyRose;
            this.emphomebtn.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emphomebtn.ForeColor = System.Drawing.Color.Maroon;
            this.emphomebtn.Location = new System.Drawing.Point(929, 27);
            this.emphomebtn.Name = "emphomebtn";
            this.emphomebtn.Size = new System.Drawing.Size(107, 45);
            this.emphomebtn.TabIndex = 27;
            this.emphomebtn.Text = "Home";
            this.emphomebtn.UseVisualStyleBackColor = false;
            this.emphomebtn.Click += new System.EventHandler(this.emphomebtn_Click);
            // 
            // empdeletebtn
            // 
            this.empdeletebtn.BackColor = System.Drawing.Color.MistyRose;
            this.empdeletebtn.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdeletebtn.ForeColor = System.Drawing.Color.Maroon;
            this.empdeletebtn.Location = new System.Drawing.Point(376, 127);
            this.empdeletebtn.Name = "empdeletebtn";
            this.empdeletebtn.Size = new System.Drawing.Size(141, 45);
            this.empdeletebtn.TabIndex = 26;
            this.empdeletebtn.Text = "Fetch Data";
            this.empdeletebtn.UseVisualStyleBackColor = false;
            this.empdeletebtn.Click += new System.EventHandler(this.empdeletebtn_Click);
            // 
            // empeditbtn
            // 
            this.empeditbtn.BackColor = System.Drawing.Color.MistyRose;
            this.empeditbtn.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empeditbtn.ForeColor = System.Drawing.Color.Maroon;
            this.empeditbtn.Location = new System.Drawing.Point(129, 419);
            this.empeditbtn.Name = "empeditbtn";
            this.empeditbtn.Size = new System.Drawing.Size(107, 45);
            this.empeditbtn.TabIndex = 25;
            this.empeditbtn.Text = "View";
            this.empeditbtn.UseVisualStyleBackColor = false;
            this.empeditbtn.Click += new System.EventHandler(this.empeditbtn_Click);
            // 
            // empaddtb
            // 
            this.empaddtb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empaddtb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empaddtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empaddtb.DefaultText = "";
            this.empaddtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empaddtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empaddtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empaddtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empaddtb.FillColor = System.Drawing.Color.MistyRose;
            this.empaddtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empaddtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empaddtb.ForeColor = System.Drawing.Color.Maroon;
            this.empaddtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empaddtb.Location = new System.Drawing.Point(27, 147);
            this.empaddtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empaddtb.Name = "empaddtb";
            this.empaddtb.PlaceholderText = "";
            this.empaddtb.SelectedText = "";
            this.empaddtb.Size = new System.Drawing.Size(314, 39);
            this.empaddtb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(22, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Employee Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Employee Position";
            // 
            // empnametb
            // 
            this.empnametb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empnametb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empnametb.DefaultText = "";
            this.empnametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empnametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empnametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empnametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empnametb.FillColor = System.Drawing.Color.MistyRose;
            this.empnametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empnametb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empnametb.ForeColor = System.Drawing.Color.Maroon;
            this.empnametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empnametb.Location = new System.Drawing.Point(230, 46);
            this.empnametb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empnametb.Name = "empnametb";
            this.empnametb.PlaceholderText = "";
            this.empnametb.SelectedText = "";
            this.empnametb.Size = new System.Drawing.Size(121, 39);
            this.empnametb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(215, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee Name";
            // 
            // empidtb
            // 
            this.empidtb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empidtb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empidtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empidtb.DefaultText = "";
            this.empidtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empidtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empidtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empidtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empidtb.FillColor = System.Drawing.Color.MistyRose;
            this.empidtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empidtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empidtb.ForeColor = System.Drawing.Color.Maroon;
            this.empidtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empidtb.Location = new System.Drawing.Point(27, 46);
            this.empidtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empidtb.Name = "empidtb";
            this.empidtb.PlaceholderText = "";
            this.empidtb.SelectedText = "";
            this.empidtb.Size = new System.Drawing.Size(121, 39);
            this.empidtb.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee ID";
            // 
            // emppostb
            // 
            this.emppostb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emppostb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.emppostb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emppostb.DefaultText = "";
            this.emppostb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emppostb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emppostb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emppostb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emppostb.FillColor = System.Drawing.Color.MistyRose;
            this.emppostb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emppostb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emppostb.ForeColor = System.Drawing.Color.Maroon;
            this.emppostb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emppostb.Location = new System.Drawing.Point(27, 244);
            this.emppostb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emppostb.Name = "emppostb";
            this.emppostb.PlaceholderText = "";
            this.emppostb.SelectedText = "";
            this.emppostb.Size = new System.Drawing.Size(314, 39);
            this.emppostb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(23, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 27);
            this.label5.TabIndex = 30;
            this.label5.Text = "Worked Days";
            // 
            // workeddaystb
            // 
            this.workeddaystb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.workeddaystb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.workeddaystb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.workeddaystb.DefaultText = "";
            this.workeddaystb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.workeddaystb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.workeddaystb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.workeddaystb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.workeddaystb.FillColor = System.Drawing.Color.MistyRose;
            this.workeddaystb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.workeddaystb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.workeddaystb.ForeColor = System.Drawing.Color.Maroon;
            this.workeddaystb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.workeddaystb.Location = new System.Drawing.Point(28, 339);
            this.workeddaystb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.workeddaystb.Name = "workeddaystb";
            this.workeddaystb.PlaceholderText = "";
            this.workeddaystb.SelectedText = "";
            this.workeddaystb.Size = new System.Drawing.Size(314, 39);
            this.workeddaystb.TabIndex = 31;
            // 
            // printPD
            // 
            this.printPD.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPD.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPD.ClientSize = new System.Drawing.Size(400, 300);
            this.printPD.Enabled = true;
            this.printPD.Icon = ((System.Drawing.Icon)(resources.GetObject("printPD.Icon")));
            this.printPD.Name = "printPD";
            this.printPD.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1129, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emphomebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryslip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox workeddaystb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox emppostb;
        private Guna.UI2.WinForms.Guna2DataGridView salaryslip;
        private System.Windows.Forms.Button emphomebtn;
        private System.Windows.Forms.Button empdeletebtn;
        private System.Windows.Forms.Button empeditbtn;
        private Guna.UI2.WinForms.Guna2TextBox empaddtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox empnametb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox empidtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPD;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}