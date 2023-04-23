using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace DataGridWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DG.ItemsSource=Songs.GetSongs();
        }
        public class Songs
        {
            public static List<Song> GetSongs()
            {
                var file = @"C:\Users\Home\Desktop\WPF\Songs.txt";
                var lines=File.ReadAllLines(file);
                var list=new List<Song>();
                for(int i= 0; i < lines.Length; i++)
                {
                    var line = lines[i].Split(',','.');
                    var song = new Song()
                    {
                        ID = int.Parse(line[0]),
                        Title = line[1],
                        Artist = line[2],
                        Album = line[3],
                        Year = int.Parse(line[4])
                      
                    };
                    list.Add(song);
                }
                return list;
            }
        }
        public class Song
        {
            public int ID { get; set; }
            public  string Title { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }
            public int Year { get; set; }
        }
    }
}
