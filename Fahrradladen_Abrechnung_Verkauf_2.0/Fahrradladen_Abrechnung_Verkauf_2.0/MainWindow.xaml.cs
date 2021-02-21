using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Fahrradladen_Abrechnung_Verkauf_2._0
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICollectionView collectionView;
        VerkaufEntities VerkaufEntities = new VerkaufEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VerkaufEntities.Artikel.Load();
            collectionView = CollectionViewSource.GetDefaultView(VerkaufEntities.Artikel.Local);
            MainGridTab1.DataContext = collectionView;
        }

        private void Button_Click_Artikel_hinzufügen(object sender, RoutedEventArgs e)
        {
            //Daten aus DataGrid auswählen und in die Zusammenfassung hinzufügen.
            dynamic Werte = DataGridyo.SelectedItem;

            string Wertestring = Werte.Artikel_Bezeichnung;

            Zuasammenfassung_Rechnung.Text += Wertestring + "\n";

            using (VerkaufEntities db = new VerkaufEntities())
            {
                Rechnungen a = new Rechnungen
                {

                    Artikel_ID = Werte.Artikel_ID,
                    Rechnungs_Datum = DateTime.Now,
                    //Date = Convert.ToDateTime("2021-03-24 00:00:00.000"),
                    Arbeitszeit = Convert.ToInt32(Arbeitszeit_Text.Text),
                    Gesamtpreis = Werte.Artikel_Preis,
                };

                db.Rechnungen.Add(a);
                //Übertragen der Änderungen an die Datenbank.
                db.SaveChanges();

            };
        }

            private void Button_Click_Arbeitszeit(object sender, RoutedEventArgs e)
            {

                if (Arbeitszeit_Text.Text == "1")
                {
                    Zuasammenfassung_Rechnung.Text += Arbeitszeit_Text.Text + " Stunde\n";
                }
                else { Zuasammenfassung_Rechnung.Text += Arbeitszeit_Text.Text + " Stunden\n"; }
            }

            private void Arbeitszeit_Text_PreviewTextInput(object sender, TextCompositionEventArgs e)
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }


            private void Arbeitszeit_Text_MouseDoubleClick(object sender, MouseButtonEventArgs e)
            {
                Arbeitszeit_Text.Text = "";
            }

            private void Button_Click_Rechnung_erstellen(object sender, RoutedEventArgs e)
            {

            }


        }
    }

