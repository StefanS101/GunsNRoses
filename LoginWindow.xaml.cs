using System.Windows;

namespace GunsNRoses
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                this.Close();
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
            }
        }

        private bool Validate()
        {
            return true;
        }
    }
}
