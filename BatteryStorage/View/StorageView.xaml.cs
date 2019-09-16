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

        //Metoda obsługująca filtr
        private bool UserFilter(object item)
        {
            //Brak filtrowania w przypadku gdy string jest null
            if (String.IsNullOrEmpty(Filter_Txtbox.Text))
                return true;

            //Zmienna sluzaca do filtrowania zawartości tabeli
            var battery = (Battery)item;
            //Przeszukanie nazwy/modelu w tabeli
            return (battery.Name.StartsWith(Filter_Txtbox.Text, StringComparison.OrdinalIgnoreCase)
                    || battery.Model.StartsWith(Filter_Txtbox.Text, StringComparison.OrdinalIgnoreCase));
        }

        //Metoda wykonująca się przy zmianie wyboru kontrolki ComboBox
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Przypisanie indexu z tabeli do zmiennej
            var index = SortList.SelectedIndex;
            //Posortowanie zawartości listy według indeksu
            storageViewModel.SortListBy(index);
        }

        
    }
}
