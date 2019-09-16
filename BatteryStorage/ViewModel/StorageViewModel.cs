using BatteryStorage.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BatteryStorage.ViewModel
{
    class StorageViewModel
    {
        //Kolekcja baterii
        public ObservableCollection<Battery> listOfBatteries;
        //Rozszerzenie funkcjonalności kolekcji o sortowanie, filtrowanie rekordów
        public ICollectionView ItemsView
        {
            get { return CollectionViewSource.GetDefaultView(listOfBatteries); }
        }

        //Konstruktor inicjujący nowa liste baterii i wpisujący przykładowe dane
        public StorageViewModel()
        {
            listOfBatteries = new ObservableCollection<Battery>();
            InitList();
        }

      
    }
}
