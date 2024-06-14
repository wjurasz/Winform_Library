using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace projekt_szkolenie_techiczne_1
{
    public partial class Borrow_book : Form
    {
        BindingSource bookBindingSource = new BindingSource();
        LibraryDAO libraryDAO = new LibraryDAO();
        public int UserID;
        public Borrow_book(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.FormClosed += new FormClosedEventHandler(Borrow_Book_FormClosed);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_panel userpanel = new User_panel(UserID);
            userpanel.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Borrow_Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Zamknij całą aplikację
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = libraryDAO.GetAllBook();
            allBooks.DataSource = bookBindingSource;
        }

        private void allBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int bookID = Convert.ToInt32(allBooks.Rows[e.RowIndex].Cells["BOOKID"].Value);
                bool isBorrowed = Convert.ToBoolean(allBooks.Rows[e.RowIndex].Cells["IsBorrowed"].Value);

                if (isBorrowed)
                {
                    MessageBox.Show("This book is already borrowed.");
                }
                else
                {
                    // Call BorrowBook method
                    libraryDAO.BorrowBook(bookID, UserID);

                    MessageBox.Show($"{UserID}");
                    MessageBox.Show("Book borrowed successfully!");

                    // Refresh book list
                    bookBindingSource.DataSource = libraryDAO.GetAllBook();
                    allBooks.DataSource = bookBindingSource;
                }
            }
        }
    }
}
