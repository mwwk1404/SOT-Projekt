using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

namespace Fahrradladen_18._02
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
    }
}
