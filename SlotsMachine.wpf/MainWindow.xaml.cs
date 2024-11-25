using System.Diagnostics.SymbolStore;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace SlotsMachine.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Random random;
        string imageLocation;
        List<Image> images;
        List<BitmapImage> symbolImages;
        int totalScore;
        const int threeMatches = 15;
        const int twoMatches = 5;
        const int noMatches = 0;


        private void btnSpin_Click(object sender, RoutedEventArgs e)
        {
            SpinTheWheel();            
            txbScore.Text = CalculateScore(images).ToString();
            totalScore += CalculateScore(images);
            txbTotalScore.Text = totalScore.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Assign variables
            random = new Random();
            imageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"img");
            images = new List<Image>();
            symbolImages = new List<BitmapImage>();
            totalScore = 0;

            //Asign images to list

            ImportImages();

            images.Add(imgSlot1);
            images.Add(imgSlot2);
            images.Add(imgSlot3);
        }


        private void ImportImages()
        {
            DirectoryInfo di = new DirectoryInfo(imageLocation);
            foreach(FileInfo fi in di.GetFiles("*.png"))
            {
                try
                {
                    symbolImages.Add(new BitmapImage(new Uri(fi.FullName, UriKind.Absolute)));
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error bij laden image {fi.Name}: {ex.Message}", "Waarschuwing",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                


            }
             
        }

        private void SpinTheWheel()
        {
            
            int max = symbolImages.Count;
            foreach(Image img in images)
            {
                img.Source = symbolImages[random.Next(max)];
            }
        }

        private int CalculateScore(List<Image> images)
        {
            if (images[0].Source == images[1].Source && images[0].Source == images[2].Source)
            {
                return threeMatches;
            }
            else if (images[0].Source == images[1].Source || images[1].Source == images[2].Source)
            {
                return twoMatches;
            }
            else
            {
                return noMatches;
            }
        }
    }
}