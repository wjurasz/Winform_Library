namespace projekt_szkolenie_techiczne_1
{
    partial class Admin_panel
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 556);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(519, 42);
            label1.Name = "label1";
            label1.Size = new Size(266, 38);
            label1.TabIndex = 2;
            label1.Text = "ADMIN_PANEL";
            // 
            // button1
            // 
            button1.Location = new Point(309, 164);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 3;
            button1.Text = "Lista_użytkowników";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(822, 164);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 4;
            button2.Text = "Lista_książek";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(822, 230);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 5;
            button3.Text = "Dodaj_książkę";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(822, 298);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 6;
            button4.Text = "Usuń_książkę";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(309, 230);
            button5.Name = "button5";
            button5.Size = new Size(154, 29);
            button5.TabIndex = 7;
            button5.Text = "Dodaj_użytkownika";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(309, 298);
            button6.Name = "button6";
            button6.Size = new Size(154, 29);
            button6.TabIndex = 8;
            button6.Text = "Usuń_użytknownika";
            button6.UseVisualStyleBackColor = true;
            // 
            // Admin_panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 556);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Admin_panel";
            Text = "Admin_panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}