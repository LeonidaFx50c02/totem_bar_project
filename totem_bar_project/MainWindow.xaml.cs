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
            prodottiSnacks.Visibility = Visibility.Collapsed;
            prodottiCalde.Visibility = Visibility.Collapsed;
            prodottiFredde.Visibility = Visibility.Collapsed;
        }

        private void dolciCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiDolci.Visibility = Visibility.Visible;
            prodottiPanini.Visibility = Visibility.Collapsed;
            prodottiSnacks.Visibility = Visibility.Collapsed;
            prodottiCalde.Visibility = Visibility.Collapsed;
            prodottiFredde.Visibility = Visibility.Collapsed;
        }

        private void snackCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiSnacks.Visibility = Visibility.Visible;
            prodottiPanini.Visibility = Visibility.Collapsed;
            prodottiDolci.Visibility = Visibility.Collapsed;
            prodottiFredde.Visibility = Visibility.Collapsed;
            prodottiCalde.Visibility = Visibility.Collapsed;
        }

        private void caldeCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiSnacks.Visibility = Visibility.Collapsed;
            prodottiPanini.Visibility = Visibility.Collapsed;
            prodottiDolci.Visibility = Visibility.Collapsed;
            prodottiFredde.Visibility = Visibility.Collapsed;
            prodottiCalde.Visibility = Visibility.Visible;
        }

        private void freddeCatButton_Click(object sender, RoutedEventArgs e)
        {
            prodottiSnacks.Visibility = Visibility.Collapsed;
            prodottiPanini.Visibility = Visibility.Collapsed;
            prodottiDolci.Visibility = Visibility.Collapsed;
            prodottiFredde.Visibility = Visibility.Visible;
            prodottiCalde.Visibility = Visibility.Collapsed;
        }

        private void Pagamento_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            schermataOrdine.Visibility = Visibility.Collapsed;
            MenuGrande.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridCaprese.Visibility = Visibility.Visible;

        }

        private void ChiudiCaprese_Click(object sender, RoutedEventArgs e)
        {
            GridCaprese.Visibility = Visibility.Collapsed;
        }

        private void Hamburger1_Click(object sender, RoutedEventArgs e)
        {
            GridHamburger.Visibility = Visibility.Visible;

        }
        private void ChiudiHamburger_Click(object sender, RoutedEventArgs e)
        {
            GridHamburger.Visibility = Visibility.Collapsed;
        }
        private void Ordina_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Verdure_Click(object sender, RoutedEventArgs e)
        {
            GridVerdure.Visibility = Visibility.Visible;

        }
        private void ChiudiVerdure_Click(object sender, RoutedEventArgs e)
        {
            GridVerdure.Visibility = Visibility.Collapsed;
        }

        private void Prosciutto_Click(object sender, RoutedEventArgs e)
        {
            GridProsciutto.Visibility = Visibility.Visible;
        }

        private void ChiudiProsciutto_Click(object sender, RoutedEventArgs e)
        {
            GridProsciutto.Visibility = Visibility.Collapsed;
        }

        private void Tramezzino_Click(object sender, RoutedEventArgs e)
        {
            GridTramezzino.Visibility = Visibility.Visible;
        }

        private void ChiudiTramezzino_Click(object sender, RoutedEventArgs e)
        {
            GridTramezzino.Visibility = Visibility.Collapsed;
        }

        private void Tiramisu_Click(object sender, RoutedEventArgs e)
        {
            GridTiramisu.Visibility = Visibility.Visible;
        }

        private void ChiudiTiramisu_Click(object sender, RoutedEventArgs e)
        {
            GridTiramisu.Visibility = Visibility.Collapsed;
        }

        
        private void Cheesecake_Click(object sender, RoutedEventArgs e)
        {
            GridCheesecake.Visibility = Visibility.Visible;
        }

        private void ChiudiCheesecake_Click(object sender, RoutedEventArgs e)
        {
            GridCheesecake.Visibility = Visibility.Collapsed;
        }

        private void Ciambelle_Click(object sender, RoutedEventArgs e)
        {
            GridCiambelle.Visibility = Visibility.Visible;
        }
        private void ChiudiCiambelle_Click(object sender, RoutedEventArgs e)
        {
            GridCiambelle.Visibility = Visibility.Collapsed;
        }

        private void Macedonia_Click(object sender, RoutedEventArgs e)
        {
            GridMacedonia.Visibility = Visibility.Visible;
        }

        private void ChiudiMacedonia_Click(object sender, RoutedEventArgs e)
        {
            GridMacedonia.Visibility = Visibility.Collapsed; 
        }

        private void Babba_Click(object sender, RoutedEventArgs e)
        {
            GridBabba.Visibility = Visibility.Visible;
        }

        private void ChiudiBabba_Click(object sender, RoutedEventArgs e)
        {
            GridBabba.Visibility = Visibility.Collapsed;
        }



    }
}
