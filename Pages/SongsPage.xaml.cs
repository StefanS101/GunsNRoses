using GunsNRoses.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace GunsNRoses.Pages
{
    /// <summary>
    /// Interaction logic for SongsPage.xaml
    /// </summary>
    public partial class SongsPage : Page
    {
        public ObservableCollection<Song> Songs { get; set; }
        MainWindow mainWindow;
        public SongsPage()
        {
            InitializeComponent();

            mainWindow = (MainWindow)Application.Current.MainWindow;

            Songs = mainWindow.Songs;

            DataContext = this;
        }
    }
}
