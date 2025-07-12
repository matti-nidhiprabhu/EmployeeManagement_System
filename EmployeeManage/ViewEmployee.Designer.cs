namespace EmployeeManage
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.empidlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empposlbl = new System.Windows.Forms.Label();
            this.empdoblbl = new System.Windows.Forms.Label();
            this.empaddlbl = new System.Windows.Forms.Label();
            this.empnamelbl = new System.Windows.Forms.Label();
            this.emprefresh = new System.Windows.Forms.Button();
            this.emphomelbl = new System.Windows.Forms.Button();
            this.empprint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.empidsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Solid Edge Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.empidlbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.empposlbl);
            this.panel1.Controls.Add(this.empdoblbl);
            this.panel1.Controls.Add(this.empaddlbl);
            this.panel1.Controls.Add(this.empnamelbl);
            this.panel1.Controls.Add(this.emprefresh);
            this.panel1.Controls.Add(this.emphomelbl);
            this.panel1.Controls.Add(this.empprint);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.empidsearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 480);
            this.panel1.TabIndex = 6;
            // 
            // empidlbl
            // 
            this.empidlbl.AutoSize = true;
            this.empidlbl.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidlbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.empidlbl.Location = new System.Drawing.Point(565, 118);
            this.empidlbl.Name = "empidlbl";
            this.empidlbl.Size = new System.Drawing.Size(144, 27);
            this.empidlbl.TabIndex = 33;
            this.empidlbl.Text = "Employee ID";
            this.empidlbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(264, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 27);
            this.label7.TabIndex = 32;
            this.label7.Text = "Employee ID";
            // 
            // empposlbl
            // 
            this.empposlbl.AutoSize = true;
            this.empposlbl.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empposlbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.empposlbl.Location = new System.Drawing.Point(565, 309);
            this.empposlbl.Name = "empposlbl";
            this.empposlbl.Size = new System.Drawing.Size(213, 27);
            this.empposlbl.TabIndex = 31;
            this.empposlbl.Text = "Employee Position";
            this.empposlbl.Visible = false;
            // 
            // empdoblbl
            // 
            this.empdoblbl.AutoSize = true;
            this.empdoblbl.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdoblbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.empdoblbl.Location = new System.Drawing.Point(565, 258);
            this.empdoblbl.Name = "empdoblbl";
            this.empdoblbl.Size = new System.Drawing.Size(165, 27);
            this.empdoblbl.TabIndex = 30;
            this.empdoblbl.Text = "Employee DOB";
            this.empdoblbl.Visible = false;
            // 
            // empaddlbl
            // 
            this.empaddlbl.AutoSize = true;
            this.empaddlbl.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empaddlbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.empaddlbl.Location = new System.Drawing.Point(565, 211);
            this.empaddlbl.Name = "empaddlbl";
            this.empaddlbl.Size = new System.Drawing.Size(214, 27);
            this.empaddlbl.TabIndex = 29;
            this.empaddlbl.Text = "Employee Address";
            this.empaddlbl.Visible = false;
            // 
            // empnamelbl
            // 
            this.empnamelbl.AutoSize = true;
            this.empnamelbl.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnamelbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.empnamelbl.Location = new System.Drawing.Point(565, 162);
            this.empnamelbl.Name = "empnamelbl";
            this.empnamelbl.Size = new System.Drawing.Size(181, 27);
            this.empnamelbl.TabIndex = 28;
            this.empnamelbl.Text = "Employee Name";
            this.empnamelbl.Visible = false;
            // 
            // emprefresh
            // 
            this.emprefresh.BackColor = System.Drawing.Color.MistyRose;
            this.emprefresh.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emprefresh.ForeColor = System.Drawing.Color.Maroon;
            this.emprefresh.Location = new System.Drawing.Point(713, 9);
            this.emprefresh.Name = "emprefresh";
            this.emprefresh.Size = new System.Drawing.Size(107, 45);
            this.emprefresh.TabIndex = 27;
            this.emprefresh.Text = "Refresh";
            this.emprefresh.UseVisualStyleBackColor = false;
            this.emprefresh.Click += new System.EventHandler(this.emprefresh_Click);
            // 
            // emphomelbl
            // 
            this.emphomelbl.BackColor = System.Drawing.Color.MistyRose;
            this.emphomelbl.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emphomelbl.ForeColor = System.Drawing.Color.Maroon;
            this.emphomelbl.Location = new System.Drawing.Point(570, 365);
            this.emphomelbl.Name = "emphomelbl";
            this.emphomelbl.Size = new System.Drawing.Size(107, 45);
            this.emphomelbl.TabIndex = 26;
            this.emphomelbl.Text = "Home";
            this.emphomelbl.UseVisualStyleBackColor = false;
            this.emphomelbl.Click += new System.EventHandler(this.emphomelbl_Click);
            // 
            // empprint
            // 
            this.empprint.BackColor = System.Drawing.Color.MistyRose;
            this.empprint.Font = new System.Drawing.Font("Solid Edge Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empprint.ForeColor = System.Drawing.Color.Maroon;
            this.empprint.Location = new System.Drawing.Point(322, 365);
            this.empprint.Name = "empprint";
            this.empprint.Size = new System.Drawing.Size(107, 45);
            this.empprint.TabIndex = 25;
            this.empprint.Text = "Print";
            this.empprint.UseVisualStyleBackColor = false;
            this.empprint.Click += new System.EventHandler(this.empprint_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(264, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Employee Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(264, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Employee DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(264, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Employee Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(264, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employee Name";
            // 
            // empidsearch
            // 
            this.empidsearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.empidsearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.empidsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empidsearch.DefaultText = "";
            this.empidsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empidsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empidsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empidsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empidsearch.FillColor = System.Drawing.Color.MistyRose;
            this.empidsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empidsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.empidsearch.ForeColor = System.Drawing.Color.Maroon;
            this.empidsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empidsearch.Location = new System.Drawing.Point(492, 15);
            this.empidsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empidsearch.Name = "empidsearch";
            this.empidsearch.PlaceholderText = "";
            this.empidsearch.SelectedText = "";
            this.empidsearch.Size = new System.Drawing.Size(121, 39);
            this.empidsearch.TabIndex = 13;
            this.empidsearch.TextChanged += new System.EventHandler(this.empidsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Solid Edge Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(285, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Solid Edge Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1063, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1196, 576);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button emprefresh;
        private System.Windows.Forms.Button emphomelbl;
        private System.Windows.Forms.Button empprint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox empidsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label empposlbl;
        private System.Windows.Forms.Label empdoblbl;
        private System.Windows.Forms.Label empaddlbl;
        private System.Windows.Forms.Label empnamelbl;
        private System.Windows.Forms.Label empidlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}