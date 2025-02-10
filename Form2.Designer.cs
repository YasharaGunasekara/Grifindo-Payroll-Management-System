namespace Griffindo_toys
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnEmp = new Button();
            btnSalary = new Button();
            btnSettings = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(199, 23);
            label1.Name = "label1";
            label1.Size = new Size(460, 77);
            label1.TabIndex = 0;
            label1.Text = "Grifindo Toys";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(305, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 225);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Lavender;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(583, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(240, 225);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnEmp
            // 
            btnEmp.BackgroundImage = (Image)resources.GetObject("btnEmp.BackgroundImage");
            btnEmp.BackgroundImageLayout = ImageLayout.Stretch;
            btnEmp.FlatStyle = FlatStyle.Flat;
            btnEmp.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmp.ForeColor = SystemColors.ActiveCaptionText;
            btnEmp.Location = new Point(78, 375);
            btnEmp.Name = "btnEmp";
            btnEmp.Size = new Size(141, 74);
            btnEmp.TabIndex = 18;
            btnEmp.Text = "Employee";
            btnEmp.UseVisualStyleBackColor = true;
            btnEmp.Click += button1_Click_1;
            // 
            // btnSalary
            // 
            btnSalary.BackgroundImage = (Image)resources.GetObject("btnSalary.BackgroundImage");
            btnSalary.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalary.ForeColor = SystemColors.ActiveCaptionText;
            btnSalary.Location = new Point(356, 375);
            btnSalary.Name = "btnSalary";
            btnSalary.Size = new Size(141, 74);
            btnSalary.TabIndex = 19;
            btnSalary.Text = "Salary";
            btnSalary.UseVisualStyleBackColor = true;
            btnSalary.Click += btnSalary_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImage = (Image)resources.GetObject("btnSettings.BackgroundImage");
            btnSettings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = SystemColors.ActiveCaptionText;
            btnSettings.Location = new Point(637, 375);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(141, 74);
            btnSettings.TabIndex = 20;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 544);
            Controls.Add(btnSettings);
            Controls.Add(btnSalary);
            Controls.Add(btnEmp);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            Text = "Home page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnEmp;
        private Button btnSalary;
        private Button btnSettings;
    }
}