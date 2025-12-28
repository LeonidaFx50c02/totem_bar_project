using System;
using System.Collections.Generic;
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

namespace totem_bar_project
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

        private void paniniCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiDolci.Visibility = Visibility.Collapsed;
            prodottiPanini.Visibility = Visibility.Visible;
        }

        private void dolciCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiDolci.Visibility = Visibility.Visible;
            prodottiPanini.Visibility = Visibility.Collapsed;
        }

        private void snackCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiSnacks.Visibility = Visibility.Visible;
            prodottiPanini.Visibility = Visibility.Collapsed;
            prodottiDolci.Visibility = Visibility.Collapsed;
            //prodottiCalde, prodottiFredde, ecc.
            //prodottiCalde.Visibility = Visibility.Collapsed;
        }

        private void caldeCatButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void freddeCatButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
