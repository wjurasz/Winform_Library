namespace projekt_szkolenie_techiczne_1
{
    partial class Login
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            userLogin = new TextBox();
            label3 = new Label();
            userPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 533);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(539, 46);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 1;
            label1.Text = "Biblioteka";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(584, 160);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.Click += label2_Click;
            // 
            // userLogin
            // 
            userLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userLogin.Location = new Point(524, 205);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(194, 27);
            userLogin.TabIndex = 3;
            userLogin.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(584, 255);
            label3.Name = "label3";
            label3.Size = new Size(75, 22);
            label3.TabIndex = 4;
            label3.Text = "HASŁO";
            label3.Click += label3_Click;
            // 
            // userPassword
            // 
            userPassword.Location = new Point(524, 297);
            userPassword.Name = "userPassword";
            userPassword.PasswordChar = 'ඞ';
            userPassword.Size = new Size(194, 27);
            userPassword.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(524, 349);
            button1.Name = "button1";
            button1.Size = new Size(194, 55);
            button1.TabIndex = 0;
            button1.Text = "Zaloguj";
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 533);
            Controls.Add(button1);
            Controls.Add(userPassword);
            Controls.Add(label3);
            Controls.Add(userLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Login";
            Text = "Logowanie";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        public Label label1;
        private Label label2;
        private TextBox userLogin;
        private Label label3;
        private TextBox userPassword;
        private Button button1;
    }
}
