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
using System.Windows.Shapes;

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


        string location = AppDomain.CurrentDomain.BaseDirectory;
        List<Image> images = new List<Image>();
        List<BitmapImage> symbols = new List<BitmapImage>();
        private void btnSpin_Click(object sender, RoutedEventArgs e)
        {
            SpinTheWheel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Asign images to list
            
            DirectoryInfo directory = new DirectoryInfo($@"{location}img\");
            foreach(FileInfo fi in directory.GetFiles())
            {
                symbols.Add(new BitmapImage(new Uri(fi.FullName, UriKind.Absolute)));
            }

            images.Add(imgSlot1);
            images.Add(imgSlot2);
            images.Add(imgSlot3);
        }

        private void SpinTheWheel()
        {
            Random random = new Random();
            int max = symbols.Count;
            foreach(Image img in images)
            {
                img.Source = symbols[random.Next(max)];
            }
        }
    }
}