using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class Form2 : Form
    {
        BindingList<PersonModel> addresses = new BindingList<PersonModel>();
        public Form2()
        {
            InitializeComponent();
        }

        private void addAddressToListButton_Click(object sender, EventArgs e)
        {
            foreach (PersonModel model in addresses)
            {
                listOfAddressBox.Items.Add(model.StreetName);
                listOfAddressBox.Items.Add($"{model.PostalCode}, {model.HouseNumber.ToString()}");
            }
        }
    }

    public class PersonModel
    {
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public int HouseNumber { get; set; }
    }
}
