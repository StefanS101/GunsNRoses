using GunsNRoses.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Vezbe2.Helpers;


namespace GunsNRoses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataIO serializer = new DataIO();

        public ObservableCollection<Song> Songs;

        public Dictionary<string, User> users;

        public MainWindow()
        {
            InitializeComponent();

            Songs = serializer.DeSerializeObject<ObservableCollection<Song>>("Songs.xml") ?? new ObservableCollection<Song>();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //foreach (Song song in Songs) { serializer.SerializeObject<Song>(song)... }
            this.Close();
        }
    }
}
