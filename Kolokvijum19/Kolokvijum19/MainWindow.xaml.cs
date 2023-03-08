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

namespace Kolokvijum19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DCDomZdravljaDataContext DC = new DCDomZdravljaDataContext();
        public MainWindow()
        {
            InitializeComponent();
            puniFirme();
        }
        private void puniFirme()
        {
            var firme = (from f in DC.Firmas
                         select f).ToList();

            cmbFirme.ItemsSource = firme;
        }
        private void puniGrid()
        {
            var korisnici = from p in DC.Pacijents
                            join pak in DC.Pakets
                            on p.IDPaketa equals pak.PaketID
                            where pak.FirmaID == ((Firma)cmbFirme.SelectedValue).FirmaID
                            select new { p.PacijentID, p.Ime, p.Prezime, p.DatumIzmene, p.Popust, pak.Naziv, pak.Cena };

            grid1.ItemsSource = korisnici;
            txtUkupno.Text = korisnici.Count().ToString();
        }

        private void cmbFirme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            puniGrid();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            gbPopust.IsEnabled = true;
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            Pacijent pac = (from p in DC.Pacijents
                            where p.PacijentID == int.Parse(txtSifraPacijenta.Text)
                            select p).Single();

            pac.Popust = int.Parse(txtNoviPopust.Text);
            pac.DatumIzmene = System.DateTime.Now.Date;

            try
            {
                DC.SubmitChanges();
            }
            catch(Exception)
            {
                MessageBox.Show("Greska");
                puniGrid();
            }
        }

        private void rbMin_Click(object sender, RoutedEventArgs e)
        {
            var min = (from p in DC.Pacijents
                       join pak in DC.Pakets
                       on p.IDPaketa equals pak.PaketID
                       where pak.FirmaID == ((Firma)cmbFirme.SelectedValue).FirmaID
                       select p.Popust).Min();

            var korisnici = from p in DC.Pacijents
                            join pak in DC.Pakets
                            on p.IDPaketa equals pak.PaketID
                            where pak.FirmaID == ((Firma)cmbFirme.SelectedValue).FirmaID && p.Popust == min
                            select new { p.PacijentID, p.Popust, pak.Naziv };

            lbPopusti.ItemsSource = korisnici;
        }

        private void rbMax_Click(object sender, RoutedEventArgs e)
        {
            var max = (from p in DC.Pacijents
                       join pak in DC.Pakets
                       on p.IDPaketa equals pak.PaketID
                       where pak.FirmaID == ((Firma)cmbFirme.SelectedValue).FirmaID
                       select p.Popust).Max();

            var korisnici = from p in DC.Pacijents
                            join pak in DC.Pakets
                            on p.IDPaketa equals pak.PaketID
                            where pak.FirmaID == ((Firma)cmbFirme.SelectedValue).FirmaID && p.Popust == max
                            select new { p.PacijentID, p.Popust, pak.Naziv };

            lbPopusti.ItemsSource = korisnici;
        }

        private void UnosNovog_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.ShowDialog();
        }
    }
}
