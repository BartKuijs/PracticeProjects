using DemoLibrary;
using System.ComponentModel;

namespace WindowsFormsMiniProject
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public PersonEntry()
        {
            InitializeComponent();

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }


        private void addressFormButton_Click_1(object sender, EventArgs e)
        {

            // Open the Address Entry form
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }


        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList()
            };
        }
    }
}