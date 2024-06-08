using MySql.Data.MySqlClient;
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
    public partial class Borrow_book : Form
    {
        BindingSource bookBindingSource = new BindingSource();
        public Borrow_book()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Borrow_Book_FormClosed);
        }
        private void Borrow_Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Zamknij całą aplikację
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibraryDAO libraryDAO = new LibraryDAO();

            bookBindingSource.DataSource = libraryDAO.GetAllBook();
            allBooks.DataSource = bookBindingSource;
        }


        

        private void allBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int bookID = Convert.ToInt32(allBooks.Rows[e.RowIndex].Cells["BookID"].Value);
                bool isBorrowed = Convert.ToBoolean(allBooks.Rows[e.RowIndex].Cells["IsBorrowed"].Value);

                if (!isBorrowed)
                {
                    BorrowBook(bookID);
                    allBooks.Rows[e.RowIndex].Cells["IsBorrowed"].Value = true;
                }
                else
                {
                    MessageBox.Show("Książka jest już wypożyczona.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
