namespace Griffindo_toys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            password = new Label();
            lblpassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(346, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1500, 1000);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(6, 3, 39);
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(426, 27);
            label2.Name = "label2";
            label2.Size = new Size(320, 40);
            label2.TabIndex = 4;
            label2.Text = "Login to your account";
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(557, 397);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 52);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(389, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(193, 29);
            txtPassword.TabIndex = 15;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(383, 174);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(190, 29);
            txtUserName.TabIndex = 14;
            // 
            // password
            // 
            password.AutoSize = true;
            password.BackColor = Color.FromArgb(3, 2, 35);
            password.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            password.ForeColor = Color.Transparent;
            password.Location = new Point(389, 254);
            password.Name = "password";
            password.Size = new Size(103, 30);
            password.TabIndex = 13;
            password.Text = "Password";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.FromArgb(3, 2, 35);
            lblpassword.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.ForeColor = Color.Transparent;
            lblpassword.Location = new Point(383, 123);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(109, 30);
            lblpassword.TabIndex = 12;
            lblpassword.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(805, 551);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(password);
            Controls.Add(lblpassword);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label password;
        private Label lblpassword;
    }
}