namespace projekt_szkolenie_techiczne_1
{
    partial class Borrow_book
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
            allBooks = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)allBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 553);
            panel1.TabIndex = 2;
            // 
            // allBooks
            // 
            allBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allBooks.Location = new Point(273, 129);
            allBooks.Name = "allBooks";
            allBooks.RowHeadersWidth = 51;
            allBooks.Size = new Size(787, 362);
            allBooks.TabIndex = 3;
            allBooks.CellMouseDoubleClick += allBooks_CellMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(273, 93);
            label2.Name = "label2";
            label2.Size = new Size(160, 33);
            label2.TabIndex = 5;
            label2.Text = "Lista książek";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(532, 22);
            button2.Name = "button2";
            button2.Size = new Size(286, 67);
            button2.TabIndex = 8;
            button2.Text = "Wyświetl wszystkie książki";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Borrow_book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 553);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(allBooks);
            Controls.Add(panel1);
            Name = "Borrow_book";
            Text = "Borrow_book";
            ((System.ComponentModel.ISupportInitialize)allBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView allBooks;
        private Label label2;
        private Button button2;
    }
}