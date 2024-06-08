using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace projekt_szkolenie_techiczne_1
{
    public partial class User_panel : Form
    {
        public int UserID;
        BindingSource bookBindingSource = new BindingSource();
        public User_panel(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.FormClosed += new FormClosedEventHandler(User_panel_FormClosed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryDAO libraryDAO = new LibraryDAO();

            bookBindingSource.DataSource = libraryDAO.GetUserBooks(this.UserID);
            dataGridView1.DataSource = bookBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void User_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Zamknij całą aplikację
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrow_book borrow_book = new Borrow_book();
            borrow_book.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}