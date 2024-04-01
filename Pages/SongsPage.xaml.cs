using GunsNRoses.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GunsNRoses.Pages
{
    /// <summary>
    /// Interaction logic for SongsPage.xaml
    /// </summary>
    public partial class SongsPage : Page
    {
        public ObservableCollection<Song> songs {  get; set; }
        MainWindow mainWindow;
        public SongsPage()
        {
            InitializeComponent();

            mainWindow = (MainWindow)Application.Current.MainWindow;


            songs = mainWindow.songs;

            DataContext = this;
        }
    }
}
