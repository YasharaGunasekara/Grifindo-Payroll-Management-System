namespace Griffindo_toys
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtEndDate = new TextBox();
            txtBeginDate = new TextBox();
            txtGovTax = new TextBox();
            label6 = new Label();
            button3 = new Button();
            txtLeaves = new TextBox();
            txtDateRange = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leelawadee UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(228, 34);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtEndDate);
            groupBox1.Controls.Add(txtBeginDate);
            groupBox1.Controls.Add(txtGovTax);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txtLeaves);
            groupBox1.Controls.Add(txtDateRange);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(47, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 309);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // txtEndDate
            // 
            txtEndDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEndDate.Location = new Point(224, 118);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(250, 27);
            txtEndDate.TabIndex = 18;
            // 
            // txtBeginDate
            // 
            txtBeginDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBeginDate.Location = new Point(224, 79);
            txtBeginDate.Name = "txtBeginDate";
            txtBeginDate.Size = new Size(250, 27);
            txtBeginDate.TabIndex = 17;
            txtBeginDate.TextChanged += txtBeginDate_TextChanged;
            // 
            // txtGovTax
            // 
            txtGovTax.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtGovTax.Location = new Point(224, 211);
            txtGovTax.Name = "txtGovTax";
            txtGovTax.Size = new Size(250, 27);
            txtGovTax.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(15, 214);
            label6.Name = "label6";
            label6.Size = new Size(156, 21);
            label6.TabIndex = 15;
            label6.Text = "Goverment Tax Rate";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(210, 260);
            button3.Name = "button3";
            button3.Size = new Size(95, 36);
            button3.TabIndex = 14;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtLeaves
            // 
            txtLeaves.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLeaves.Location = new Point(224, 163);
            txtLeaves.Name = "txtLeaves";
            txtLeaves.Size = new Size(250, 27);
            txtLeaves.TabIndex = 11;
            // 
            // txtDateRange
            // 
            txtDateRange.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateRange.Location = new Point(224, 35);
            txtDateRange.Name = "txtDateRange";
            txtDateRange.Size = new Size(250, 27);
            txtDateRange.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(15, 166);
            label5.Name = "label5";
            label5.Size = new Size(169, 21);
            label5.TabIndex = 3;
            label5.Text = "No.of Leaves per Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(15, 120);
            label4.Name = "label4";
            label4.Size = new Size(166, 21);
            label4.TabIndex = 2;
            label4.Text = "Salary Cycle End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(15, 79);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 1;
            label3.Text = "Salary Cycle Begin Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(15, 37);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 0;
            label2.Text = "Date Range";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(606, 509);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form5";
            Text = "Settings";
            Load += Form5_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtLeaves;
        private TextBox txtDateRange;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Label label6;
        private TextBox txtGovTax;
        private TextBox txtEndDate;
        private TextBox txtBeginDate;
    }
}