namespace WindowsFormsHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void welcomeButton_Click(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = "";

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter a First Name.", "Blank First Name field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
            }
            else
            {
                firstName = firstNameTextBox.Text;

            }
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter a Last Name.", "Blank Last Name field",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Focus();
            }
            else
            {
                lastName = lastNameTextBox.Text;

            }


            if (firstName != "" && lastName != "")
            {
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                MessageBox.Show($"Hi {firstName} {lastName}");
            }



        }

        private void adresButton_Click(object sender, EventArgs e)
        {
            Form2 adresForm = new Form2();
            adresForm.Activate();
        }
    }
}