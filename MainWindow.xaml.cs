using Frames.Pages;
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

namespace Frames
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

        private void OnPageOne(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page1();

        }

        private void OnPageTwo(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page2();

        }

        private void OnPageThree(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Page3();

        }
    }
}