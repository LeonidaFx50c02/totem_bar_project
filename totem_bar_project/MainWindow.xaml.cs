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
        string carrello = "";
        string metodoPagamento = "";
        public MainWindow()
        {
            InitializeComponent();
            inizializzaProdotti();
        }

        private void inizializzaProdotti()
        {

            Categorie cheesecake = new Categorie("Cheesecake", 4, TipoCategoria.Dolci, "Cheesecake", new List<Allergeni> { Allergeni.latte, Allergeni.uova }, new List<TipoIngredienti> { });
            Categorie tiramisu = new Categorie("Tiramisù", 4, TipoCategoria.Dolci, "Tiramisù", new List<Allergeni> { Allergeni.latte, Allergeni.uova }, new List<TipoIngredienti> { });
            Categorie gelato = new Categorie("Gelato", 3, TipoCategoria.Dolci, "Gelato", new List<Allergeni> { Allergeni.latte }, new List<TipoIngredienti> { });
            Categorie macedonia = new Categorie("Macedonia", 3, TipoCategoria.Dolci, "Macedonia di frutta", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie dolce5 = new Categorie("Dolce del giorno", 3, TipoCategoria.Dolci, "Dolce speciale", new List<Allergeni> { }, new List<TipoIngredienti> { });

            Categorie patatine = new Categorie("Patatine", 2, TipoCategoria.Snack, "Patatine fritte", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie popcorn = new Categorie("Popcorn", 2, TipoCategoria.Snack, "Popcorn salati", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie crackers = new Categorie("Crackers", 2, TipoCategoria.Snack, "Crackers", new List<Allergeni> { Allergeni.glutine }, new List<TipoIngredienti> { });
            Categorie taralli = new Categorie("Taralli", 2, TipoCategoria.Snack, "Taralli", new List<Allergeni> { Allergeni.glutine }, new List<TipoIngredienti> { });
            Categorie snackChoco = new Categorie("Snack Choco", 3, TipoCategoria.Snack, "Snack al cioccolato", new List<Allergeni> { Allergeni.latte }, new List<TipoIngredienti> { });

            Categorie cioccolata = new Categorie("Cioccolata", 3, TipoCategoria.BevandeCalde, "Cioccolata calda", new List<Allergeni> { Allergeni.latte }, new List<TipoIngredienti> { });
            Categorie caffe = new Categorie("Caffè", 1, TipoCategoria.BevandeCalde, "Caffè espresso", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie balsamo = new Categorie("Balsamo", 2, TipoCategoria.BevandeCalde, "Bevanda calda", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie cappuccino = new Categorie("Cappuccino", 2, TipoCategoria.BevandeCalde, "Cappuccino", new List<Allergeni> { Allergeni.latte }, new List<TipoIngredienti> { });
            Categorie theCaldo = new Categorie("Thè", 2, TipoCategoria.BevandeCalde, "Thè caldo", new List<Allergeni> { }, new List<TipoIngredienti> { });

            Categorie cocaCola = new Categorie("Coca Cola", 2, TipoCategoria.BevandeFredde, "Coca Cola", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie teFreddo = new Categorie("Tè freddo", 2, TipoCategoria.BevandeFredde, "Tè freddo", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie fanta = new Categorie("Fanta", 2, TipoCategoria.BevandeFredde, "Fanta", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie sprite = new Categorie("Sprite", 2, TipoCategoria.BevandeFredde, "Sprite", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie redBull = new Categorie("Red Bull", 3, TipoCategoria.BevandeFredde, "Energy drink", new List<Allergeni> { }, new List<TipoIngredienti> { });
            Categorie monster = new Categorie("Monster", 3, TipoCategoria.BevandeFredde, "Energy drink", new List<Allergeni> { }, new List<TipoIngredienti> { });
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
            schermataOrdine.Visibility = Visibility.Collapsed;
            pagamentoSchermata.Visibility = Visibility.Visible;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            schermataOrdine.Visibility = Visibility.Collapsed;
            MenuGrande.Visibility = Visibility.Visible;
        }

        private void Caprese_Click(object sender, RoutedEventArgs e)
        {
            GridCaprese.Visibility = Visibility.Visible;
            Categorie caprese = new Categorie("Caprese", 4, TipoCategoria.Panini, "Panino caprese", new List<Allergeni> { Allergeni.glutine, Allergeni.latte }, new List<TipoIngredienti> { TipoIngredienti.Insalata, TipoIngredienti.Pomodoro, TipoIngredienti.Pane, TipoIngredienti.Formaggio });

        }

        private void ChiudiCaprese_Click(object sender, RoutedEventArgs e)
        {
            GridCaprese.Visibility = Visibility.Collapsed;
        }

        private void Hamburger1_Click(object sender, RoutedEventArgs e)
        {
            GridHamburger.Visibility = Visibility.Visible;
            Categorie hamburger = new Categorie("Hamburger", 5, TipoCategoria.Panini, "Panino con hamburger", new List<Allergeni> { Allergeni.glutine }, new List<TipoIngredienti> { TipoIngredienti.Insalata, TipoIngredienti.Pomodoro, TipoIngredienti.Pane, TipoIngredienti.Carne, TipoIngredienti.Formaggio });
            carrello += hamburger.GetNome();

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
            Categorie verdure = new Categorie("Verdure", 4, TipoCategoria.Panini, "Panino alle verdure", new List<Allergeni> { Allergeni.glutine }, new List<TipoIngredienti> { TipoIngredienti.Pane, TipoIngredienti.Melanzane, TipoIngredienti.Zucchine, TipoIngredienti.Insalata });

        }
        private void ChiudiVerdure_Click(object sender, RoutedEventArgs e)
        {
            GridVerdure.Visibility = Visibility.Collapsed;
        }

        private void Prosciutto_Click(object sender, RoutedEventArgs e)
        {
            GridProsciutto.Visibility = Visibility.Visible;
            Categorie prosciutto = new Categorie("Prosciutto", 4, TipoCategoria.Panini, "Panino al prosciutto", new List<Allergeni> { Allergeni.glutine }, new List<TipoIngredienti> { TipoIngredienti.Pane, TipoIngredienti.Formaggio, TipoIngredienti.Prosciutto });
        }

        private void ChiudiProsciutto_Click(object sender, RoutedEventArgs e)
        {
            GridProsciutto.Visibility = Visibility.Collapsed;
        }

        private void Tramezzino_Click(object sender, RoutedEventArgs e)
        {
            GridTramezzino.Visibility = Visibility.Visible;
            Categorie tramezzino = new Categorie("Tramezzino", 3, TipoCategoria.Panini, "Tramezzino classico", new List<Allergeni> { Allergeni.glutine, Allergeni.uova }, new List<TipoIngredienti> { TipoIngredienti.Insalata, TipoIngredienti.Pomodoro, TipoIngredienti.Pane });
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

        private void Popcorn_Click(object sender, RoutedEventArgs e)
        {
            GridPopcorn.Visibility = Visibility.Visible;
        }

        private void ChiudiPopcorn_Click(object sender, RoutedEventArgs e)
        {
            GridPopcorn.Visibility = Visibility.Collapsed;
        }

        private void Milka_Click(object sender, RoutedEventArgs e)
        {
            GridMilka.Visibility = Visibility.Visible;
        }

        private void ChiudiMilka_Click(object sender, RoutedEventArgs e)
        {
            GridMilka.Visibility = Visibility.Collapsed;
        }

        private void Taralli_Click(object sender, RoutedEventArgs e)
        {
            GridTaralli.Visibility = Visibility.Visible;
        }

        private void ChiudiTaralli_Click(object sender, RoutedEventArgs e)
        {
            GridTaralli.Visibility = Visibility.Collapsed;
        }

        private void Crackers_Click(object sender, RoutedEventArgs e)
        {
            GridCrackers.Visibility = Visibility.Visible;
        }

        private void ChiudiCrackers_Click(object sender, RoutedEventArgs e)
        {
            GridCrackers.Visibility = Visibility.Collapsed;
        }

        private void Patatine_Click(object sender, RoutedEventArgs e)
        {
            GridPatatine.Visibility = Visibility.Visible;
        }

        private void ChiudiPatatine_Click(object sender, RoutedEventArgs e)
        {
            GridPatatine.Visibility = Visibility.Collapsed;
        }

        private void Mocaccino_Click(object sender, RoutedEventArgs e)
        {
            GridMocaccino.Visibility = Visibility.Visible;
        }

        private void ChiudiMocaccino_Click(object sender, RoutedEventArgs e)
        {
            GridMocaccino.Visibility = Visibility.Collapsed;
        }

        private void Caffe_Click(object sender, RoutedEventArgs e)
        {
            GridCaffe.Visibility = Visibility.Visible;
        }

        private void ChiudiCaffe_Click(object sender, RoutedEventArgs e)
        {
            GridCaffe.Visibility = Visibility.Collapsed;
        }

        private void The_Click(object sender, RoutedEventArgs e)
        {
            GridThe.Visibility = Visibility.Visible;
        }

        private void ChiudiThe_Click(object sender, RoutedEventArgs e)
        {
            GridThe.Visibility = Visibility.Collapsed;
        }

        private void Cappuccino_Click(object sender, RoutedEventArgs e)
        {
            GridCappuccino.Visibility = Visibility.Visible;
        }

        private void ChiudiCappuccino_Click(object sender, RoutedEventArgs e)
        {
            GridCappuccino.Visibility = Visibility.Collapsed;
        }
        private void Cioccolata_Click(object sender, RoutedEventArgs e)
        {
            GridCioccolata.Visibility = Visibility.Visible;
        }
        private void ChiudiCioccolata_Click(object sender, RoutedEventArgs e)
        {
            GridCioccolata.Visibility = Visibility.Collapsed;
        }

        private void Red_Bull_Click(object sender, RoutedEventArgs e)
        {
            GridRedbull.Visibility = Visibility.Visible;
        }
        private void ChiudiRedbull_Click(object sender, RoutedEventArgs e)
        {
            GridRedbull.Visibility = Visibility.Collapsed;
        }
        private void Coca_cola_Click(object sender, RoutedEventArgs e)
        {
            GridCocacola.Visibility = Visibility.Visible;
        }

        private void ChiudiCocacola_Click(object sender, RoutedEventArgs e)
        {
            GridCocacola.Visibility = Visibility.Collapsed;
        }

        private void Sprite_Click(object sender, RoutedEventArgs e)
        {
            GridSprite.Visibility = Visibility.Visible;
        }

        private void ChiudiSprite_Click(object sender, RoutedEventArgs e)
        {
            GridSprite.Visibility = Visibility.Collapsed;
        }

        private void Te_Click(object sender, RoutedEventArgs e)
        {
            GridTe.Visibility = Visibility.Visible;
        }

        private void ChiudiTe_Click(object sender, RoutedEventArgs e)
        {
            GridTe.Visibility = Visibility.Collapsed;
        }

        private void Fanta_Click(object sender, RoutedEventArgs e)
        {
            GridFanta.Visibility = Visibility.Visible;
        }
        private void ChiudiFanta_Click(object sender, RoutedEventArgs e)
        {
            GridFanta.Visibility = Visibility.Collapsed;
        }
        private void Monster_Click(object sender, RoutedEventArgs e)
        {
            GridMonster.Visibility = Visibility.Visible;
        }
        private void ChiudiMonster_Click(object sender, RoutedEventArgs e)
        {
            GridMonster.Visibility = Visibility.Collapsed;
        }
        private void btnOrdina_Click(object sender, RoutedEventArgs e)
        {
            MenuGrande.Visibility = Visibility.Collapsed;
            schermataOrdine.Visibility = Visibility.Visible;
        }
        private void ResetBottoniPagamento()
        {
            Carta_button.Opacity = 1;
            Contanti_button.Opacity = 1;
            Contactless_button.Opacity = 1;
        }

        private void Carta_button_Click(object sender, RoutedEventArgs e)
        {
            ResetBottoniPagamento();

            Contanti_button.Opacity = 0.6;
            Contactless_button.Opacity = 0.6;
            metodoPagamento = "Carta";
        }

        private void Contanti_button_Click(object sender, RoutedEventArgs e)
        {
            ResetBottoniPagamento();
            Carta_button.Opacity = 0.6;
            Contactless_button.Opacity = 0.6;
            metodoPagamento = "Contanti";
        }

        private void Contactless_button_Click(object sender, RoutedEventArgs e)
        {
            ResetBottoniPagamento();
            Carta_button.Opacity = 0.6;
            Contanti_button.Opacity = 0.6;
            metodoPagamento = "Contactless";
        }

        private void AnnullaPagamento_Click(object sender, RoutedEventArgs e)
        {
            pagamentoSchermata.Visibility = Visibility.Collapsed;
            schermataOrdine.Visibility = Visibility.Visible;
        }

        private void ConfermaPagamento_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    
        
    }
