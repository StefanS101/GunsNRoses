using GunsNRoses.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace GunsNRoses
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public Dictionary<string, User> users = new Dictionary<string, User>();
        public LoginWindow()
        {
            InitializeComponent();
            users.Add("admin", new User("admin", "admin", UserRole.Admin));
            users.Add("visitor", new User("visitor", "visitor", UserRole.Visitor));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                if (ValidLogin(this.NameTextBox.Text, this.PasswordTextBox.Password))
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }


        private bool ValidLogin(string name, string password)
        {
            if (users.ContainsKey(name))
            {
                if (password == users[name].Password)
                    return true;
                else
                {
                    this.PasswordErrorLabel.Content = "Wrong password!";
                    return false;
                }
            }
            else
            {
                this.NameErrorLabel.Content = "User doesn't exist!";
                return false;
            }
        }
        private bool Validate()
        {
            bool isValid = true;

            if (NameTextBox.Text.Trim().Equals(string.Empty) ||
                NameTextBox.Text.Trim().Equals("Input username"))
            {
                isValid = false;
                NameErrorLabel.Content = "Username field cannot be empty!";
                NameTextBox.BorderBrush = Brushes.Red;
            }


            if (PasswordTextBox.Password.Equals(string.Empty) ||
                PasswordTextBox.Password.Equals("Input password"))
            {
                isValid = false;
                this.PasswordErrorLabel.Content = "Password field cannot be empty!";
                PasswordTextBox.BorderBrush = Brushes.Red;
            }

                return isValid;
        }

        private void NameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.NameTextBox.Foreground = Brushes.Black;
            this.NameErrorLabel.Content = string.Empty;
            this.NameTextBox.Text = string.Empty;
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            this.PasswordErrorLabel.Content = string.Empty;

        }
    }



}
