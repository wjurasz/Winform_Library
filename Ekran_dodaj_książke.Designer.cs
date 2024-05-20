namespace projekt_szkolenie_techiczne_1
{
    partial class Ekran_dodaj_książke
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 584);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(523, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 38);
            label1.TabIndex = 2;
            label1.Text = "Dodaj książke";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(605, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 22);
            label2.TabIndex = 4;
            label2.Text = "Tytuł";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(600, 174);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 5;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(578, 269);
            label4.Name = "label4";
            label4.Size = new Size(114, 22);
            label4.TabIndex = 6;
            label4.Text = "Rok wydania";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(600, 360);
            label5.Name = "label5";
            label5.Size = new Size(48, 22);
            label5.TabIndex = 7;
            label5.Text = "Opis";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(491, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(389, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(491, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(389, 399);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(491, 27);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(578, 471);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "DODAJ";
            button1.UseVisualStyleBackColor = true;
            // 
            // Ekran_dodaj_książke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 584);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Ekran_dodaj_książke";
            Text = "Ekran_dodaj_książke";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
    }
}