namespace projekt_szkolenie_techiczne_1
{
    partial class User_panel
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 553);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(523, 22);
            label1.Name = "label1";
            label1.Size = new Size(286, 39);
            label1.TabIndex = 2;
            label1.Text = "Witaj użytkowniku!";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(273, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(787, 258);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(273, 195);
            label2.Name = "label2";
            label2.Size = new Size(343, 33);
            label2.TabIndex = 4;
            label2.Text = "Lista wypożyczonych książek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(570, 503);
            label3.Name = "label3";
            label3.Size = new Size(490, 22);
            label3.TabIndex = 5;
            label3.Text = "Aby dokonać zwrotu książki, należy klinkąć na nią dwa razy!";
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(273, 95);
            button1.Name = "button1";
            button1.Size = new Size(286, 67);
            button1.TabIndex = 6;
            button1.Text = "Wyświetl wypożyczone książki";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(774, 95);
            button2.Name = "button2";
            button2.Size = new Size(286, 67);
            button2.TabIndex = 7;
            button2.Text = "Wypożycz książkę";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // User_panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "User_panel";
            Text = "Panel_Użytkownika";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}