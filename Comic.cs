using System.Windows.Media.Imaging;
namespace HF_14_LINQ_JimmyComics
{
    class Comic
    {
        public string Name { get; set; }
        public int Issue { get; set; }
        public int Year { get; set; }
        public string CoverPrice { get; set; }
        public string Synopsis { get; set; }
        public string MainVillain { get; set; }
        public BitmapImage Cover { get; set; }
    }
}
