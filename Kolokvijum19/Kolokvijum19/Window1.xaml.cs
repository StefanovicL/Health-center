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
using System.Windows.Shapes;

namespace Kolokvijum19
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DCDomZdravljaDataContext DC = new DCDomZdravljaDataContext();
        public Window1()
        {
            InitializeComponent();
            puniFirme();
        }
        private void puniFirme()
        {
            var firme = (from f in DC.Firmas
                         select f).ToList();

            cmbFirma.ItemsSource = firme;
        }
        private void puniPakete()
        {
            var paket = (from p in DC.Pakets
                         where p.FirmaID == ((Firma)cmbFirma.SelectedValue).FirmaID
                         select p).ToList();

            cmbPaket.ItemsSource = paket;
        }

        private void cmbFirma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            puniPakete();
        }

        private void btnPotvrdi_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(txtSifra.Text) && !String.IsNullOrEmpty(txtIme.Text) && !String.IsNullOrEmpty(txtPrezime.Text) &&
                !String.IsNullOrEmpty(txtCena.Text))
            {
                Pacijent nov = new Pacijent
                {
                    PacijentID = int.Parse(txtSifra.Text),
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumIzmene = DateTime.Now.Date,
                    Popust = int.Parse(txtPopust.Text),
                    IDPaketa = ((Paket)cmbPaket.SelectedValue).PaketID
                };

                DC.Pacijents.InsertOnSubmit(nov);

                try
                {
                    DC.SubmitChanges();
                    MessageBox.Show("Uspesno dodat u bazu");
                    this.Close();
                }
                catch(Exception)
                {
                    MessageBox.Show("Greska");
                }
            }
            else
            {
                MessageBox.Show("Sva polja su obavezna");
            }
        }
    }
}
