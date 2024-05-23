namespace projekt_szkolenie_techiczne_1
{
    public partial class Login : Form
    {
        BindingSource usersBindingSource = new BindingSource();
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryDAO libraryDAO = new LibraryDAO();

            usersBindingSource.DataSource = libraryDAO;
            if (libraryDAO.CheckUser(userLogin.Text, userPassword.Text))
            {
                MessageBox.Show("Zalogowano pomyœlnie!");

                this.Hide();

            }
            else
            {
                MessageBox.Show("Nie zalogowano, nieprawid³owe dane logowanie!!!");
            }


        }
    }
}
