using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProjectHomeWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        BindingList<PersonModel> messages = new BindingList<PersonModel>();
        public MainWindow()
        {
            InitializeComponent();
            MessageListBox.ItemsSource = messages;
        }

        private void SayHiButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            var person = new PersonModel();
            person.FirstName = firstName;
            person.LastName = lastName;

            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ) 
            {
                MessageBox.Show("Please enter a First or Last Name.", "Blank First/Last Name field");
            }
            else
            {
                messages.Add(person);
                var addresWindow = new Addresses();
                addresWindow.ShowDialog();
            }


            
        }
        

    }

}
