using BatteryStorage.Model;
using BatteryStorage.ViewModel;
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

namespace BatteryStorage.View
{
    /// <summary>
    /// Interaction logic for StorageView.xaml
    /// </summary>
    public partial class StorageView : UserControl
    {
        //Inicjalizacja viewmodelu z którego korzystamy w całym widoku
        private StorageViewModel storageViewModel;

        //Konstruktor widoku
        public StorageView()
        {
            //Utworzenie nowego obiektu klasy StorageViewModel
            storageViewModel = new StorageViewModel();
            //Inicjalizacja zawartości okna
            InitializeComponent();
            //Zbindowanie zawartości tabeli do widoku viewmodelu
            this.DataGrid.ItemsSource = storageViewModel.ItemsView;
            //Przypisanie filtru do metody UserFilter
            storageViewModel.ItemsView.Filter = UserFilter;
        }


    }
}
