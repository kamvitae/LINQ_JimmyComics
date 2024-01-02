using System.Windows;
using System.Windows.Controls;

namespace HF_14_LINQ_JimmyComics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ComicQueryManager comicQueryManager;

        public MainWindow()
        {
            InitializeComponent();

            comicQueryManager = FindResource("comicQueryManager") as ComicQueryManager;
            comicQueryManager.UpdateQueryResults(comicQueryManager.AvailableQueries[0]);
        }

        private void ListView_selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count >= 1 && e.AddedItems[0] is ComicQuery)
            {
                comicQueryManager.CurrentQueryResults.Clear();
                comicQueryManager.UpdateQueryResults(e.AddedItems[0] as ComicQuery);
            }
        }
    }
}
