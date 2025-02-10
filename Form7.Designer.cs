namespace Griffindo_toys
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox5 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            dateTimePicker4 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            comboBox2 = new ComboBox();
            label18 = new Label();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Location = new Point(30, 210);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(736, 326);
            reportViewer1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(dateTimePicker4);
            groupBox5.Controls.Add(dateTimePicker3);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(label20);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(comboBox2);
            groupBox5.Controls.Add(label18);
            groupBox5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.ForeColor = SystemColors.ActiveCaptionText;
            groupBox5.Location = new Point(31, 11);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(733, 178);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Report Generation";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(144, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 23);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(326, 122);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(312, 46);
            button1.TabIndex = 20;
            button1.Text = "Payment summary for all the employees\r\n for a given month range";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkGray;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(326, 72);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(312, 46);
            button6.TabIndex = 19;
            button6.Text = "Salary summary for couple of months for an employee";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGray;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(326, 24);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(312, 44);
            button5.TabIndex = 18;
            button5.Text = "Monthly Salary Report for an Employee";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker4.Location = new Point(144, 129);
            dateTimePicker4.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(141, 23);
            dateTimePicker4.TabIndex = 17;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker3.Location = new Point(144, 94);
            dateTimePicker3.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(141, 23);
            dateTimePicker3.TabIndex = 16;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(8, 128);
            label21.Name = "label21";
            label21.Size = new Size(64, 17);
            label21.TabIndex = 15;
            label21.Text = "End Date";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(5, 98);
            label20.Name = "label20";
            label20.Size = new Size(76, 17);
            label20.TabIndex = 14;
            label20.Text = "Begin Date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(5, 61);
            label19.Name = "label19";
            label19.Size = new Size(49, 17);
            label19.TabIndex = 12;
            label19.Text = "Month";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(144, 22);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(141, 23);
            comboBox2.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(5, 27);
            label18.Name = "label18";
            label18.Size = new Size(90, 17);
            label18.TabIndex = 10;
            label18.Text = "Employee No";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(834, 571);
            Controls.Add(groupBox5);
            Controls.Add(reportViewer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form7";
            Text = "Report Generation";
            Load += Form7_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GroupBox groupBox5;
        private Button button1;
        private Button button6;
        private Button button5;
        private DateTimePicker dateTimePicker4;
        private DateTimePicker dateTimePicker3;
        private Label label21;
        private Label label20;
        private Label label19;
        private ComboBox comboBox2;
        private Label label18;
        private DateTimePicker dateTimePicker1;
    }
}