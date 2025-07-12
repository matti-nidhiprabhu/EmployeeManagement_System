namespace EmployeeManage
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empid = new Guna.UI2.WinForms.Guna2TextBox();
            this.empname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empadd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Empaddbtn = new System.Windows.Forms.Button();
            this.empeditbtn = new System.Windows.Forms.Button();
            this.empdeletebtn = new System.Windows.Forms.Button();
            this.empdgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.emphomebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.empdob = new System.Windows.Forms.DateTimePicker();
            this.emppos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Solid Edge Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage Employee";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.empdgv);
            this.panel1.Controls.Add(this.emphomebtn);
            this.panel1.Controls.Add(this.empdeletebtn);
            this.panel1.Controls.Add(this.empeditbtn);
            this.panel1.Controls.Add(this.Empaddbtn);
            this.panel1.Controls.Add(this.empdob);
            this.panel1.Controls.Add(this.emppos);
            this.panel1.Controls.Add(this.empadd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.empname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.empid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 480);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // empid
            // 
            this.empid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid.DefaultText = "";
            this.empid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empid.FillColor = System.Drawing.Color.MistyRose;
            this.empid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empid.ForeColor = System.Drawing.Color.Maroon;
            this.empid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empid.Location = new System.Drawing.Point(18, 65);
            this.empid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empid.Name = "empid";
            this.empid.PlaceholderText = "";
            this.empid.SelectedText = "";
            this.empid.Size = new System.Drawing.Size(121, 39);
            this.empid.TabIndex = 13;
            // 
            // empname
            // 
            this.empname.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empname.DefaultText = "";
            this.empname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empname.FillColor = System.Drawing.Color.MistyRose;
            this.empname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empname.ForeColor = System.Drawing.Color.Maroon;
            this.empname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empname.Location = new System.Drawing.Point(230, 65);
            this.empname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empname.Name = "empname";
            this.empname.PlaceholderText = "";
            this.empname.SelectedText = "";
            this.empname.Size = new System.Drawing.Size(121, 39);
            this.empname.TabIndex = 15;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Employee Position";
            // 
            // empadd
            // 
            this.empadd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empadd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empadd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empadd.DefaultText = "";
            this.empadd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empadd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empadd.FillColor = System.Drawing.Color.MistyRose;
            this.empadd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empadd.ForeColor = System.Drawing.Color.Maroon;
            this.empadd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empadd.Location = new System.Drawing.Point(18, 168);
            this.empadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empadd.Name = "empadd";
            this.empadd.PlaceholderText = "";
            this.empadd.SelectedText = "";
            this.empadd.Size = new System.Drawing.Size(314, 39);
            this.empadd.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(22, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Employee Address";
            // 
            // Empaddbtn
            // 
            this.Empaddbtn.BackColor = System.Drawing.Color.MistyRose;
            this.Empaddbtn.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empaddbtn.ForeColor = System.Drawing.Color.Maroon;
            this.Empaddbtn.Location = new System.Drawing.Point(18, 383);
            this.Empaddbtn.Name = "Empaddbtn";
            this.Empaddbtn.Size = new System.Drawing.Size(107, 45);
            this.Empaddbtn.TabIndex = 24;
            this.Empaddbtn.Text = "Add";
            this.Empaddbtn.UseVisualStyleBackColor = false;
            this.Empaddbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // empeditbtn
            // 
            this.empeditbtn.BackColor = System.Drawing.Color.MistyRose;
            this.empeditbtn.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empeditbtn.ForeColor = System.Drawing.Color.Maroon;
            this.empeditbtn.Location = new System.Drawing.Point(131, 383);
            this.empeditbtn.Name = "empeditbtn";
            this.empeditbtn.Size = new System.Drawing.Size(107, 45);
            this.empeditbtn.TabIndex = 25;
            this.empeditbtn.Text = "Edit";
            this.empeditbtn.UseVisualStyleBackColor = false;
            this.empeditbtn.Click += new System.EventHandler(this.empeditbtn_Click_1);
            // 
            // empdeletebtn
            // 
            this.empdeletebtn.BackColor = System.Drawing.Color.MistyRose;
            this.empdeletebtn.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdeletebtn.ForeColor = System.Drawing.Color.Maroon;
            this.empdeletebtn.Location = new System.Drawing.Point(244, 383);
            this.empdeletebtn.Name = "empdeletebtn";
            this.empdeletebtn.Size = new System.Drawing.Size(107, 45);
            this.empdeletebtn.TabIndex = 26;
            this.empdeletebtn.Text = "Delete";
            this.empdeletebtn.UseVisualStyleBackColor = false;
            this.empdeletebtn.Click += new System.EventHandler(this.empdeletebtn_Click_1);
            // 
            // empdgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.empdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.empdgv.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empdgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.empdgv.ColumnHeadersHeight = 4;
            this.empdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empdgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.empdgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empdgv.Location = new System.Drawing.Point(573, 34);
            this.empdgv.Name = "empdgv";
            this.empdgv.RowHeadersVisible = false;
            this.empdgv.RowHeadersWidth = 51;
            this.empdgv.RowTemplate.Height = 24;
            this.empdgv.Size = new System.Drawing.Size(562, 419);
            this.empdgv.TabIndex = 28;
            this.empdgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.empdgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.empdgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.empdgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.empdgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.empdgv.ThemeStyle.BackColor = System.Drawing.Color.MistyRose;
            this.empdgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empdgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.empdgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.empdgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.empdgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.empdgv.ThemeStyle.HeaderStyle.Height = 4;
            this.empdgv.ThemeStyle.ReadOnly = false;
            this.empdgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.empdgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.empdgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empdgv.ThemeStyle.RowsStyle.Height = 24;
            this.empdgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.empdgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.empdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empdgv_CellContentClick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Solid Edge Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1081, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // emphomebtn
            // 
            this.emphomebtn.BackColor = System.Drawing.Color.MistyRose;
            this.emphomebtn.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emphomebtn.ForeColor = System.Drawing.Color.Maroon;
            this.emphomebtn.Location = new System.Drawing.Point(362, 383);
            this.emphomebtn.Name = "emphomebtn";
            this.emphomebtn.Size = new System.Drawing.Size(107, 45);
            this.emphomebtn.TabIndex = 27;
            this.emphomebtn.Text = "Home";
            this.emphomebtn.UseVisualStyleBackColor = false;
            this.emphomebtn.Click += new System.EventHandler(this.emphomebtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(264, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Employee DOB";
            // 
            // empdob
            // 
            this.empdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdob.Location = new System.Drawing.Point(269, 283);
            this.empdob.Name = "empdob";
            this.empdob.Size = new System.Drawing.Size(200, 30);
            this.empdob.TabIndex = 23;
            // 
            // emppos
            // 
            this.emppos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emppos.FormattingEnabled = true;
            this.emppos.Items.AddRange(new object[] {
            "Senior developer",
            "Assistant manager",
            "Junior developer",
            "Intern"});
            this.emppos.Location = new System.Drawing.Point(27, 285);
            this.emppos.Name = "emppos";
            this.emppos.Size = new System.Drawing.Size(187, 30);
            this.emppos.TabIndex = 22;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1147, 590);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox empadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox empname;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox empid;
        private System.Windows.Forms.Button empdeletebtn;
        private System.Windows.Forms.Button empeditbtn;
        private System.Windows.Forms.Button Empaddbtn;
        private Guna.UI2.WinForms.Guna2DataGridView empdgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button emphomebtn;
        private System.Windows.Forms.DateTimePicker empdob;
        private System.Windows.Forms.ComboBox emppos;
        private System.Windows.Forms.Label label5;
    }
}