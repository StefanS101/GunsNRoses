using GunsNRoses.Model;
using System;
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
            foreach (Song song in Songs) {
                serializer.SerializeObject<Song>(song,"/songs in rtf files/"+ song.Name + ".rtf");
            }
            this.Close();
        }

        private void AddSong_Button_Click(object sender, RoutedEventArgs e)
        {
            String pageUri = "Pages/" + "AddSongPage" + ".xaml";
            MainFrame.Navigate(new Uri(pageUri, UriKind.RelativeOrAbsolute));
        }
    }
}
