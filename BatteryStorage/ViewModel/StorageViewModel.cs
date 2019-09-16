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

        //Metoda dodająca przedmiot do listy
        public void AddItemToList(string name, string model, string type, double voltage, int capacity, double resistance, int levelOfCharge)
        {
            //Wygenerowanie identyfikatora
            Guid guid = Guid.NewGuid();
            guid.ToString().Substring(0, 6);
            //Lista inicjalizacyjna nowego obiektu baterii
            Battery battery = new Battery
            {
                IsSelected = false,
                ID = guid,
                Name = name,
                Model = model,
                Type = type,
                Voltage = voltage,
                Capacity = capacity,
                Resistance = resistance,
                LevelOfCharge = levelOfCharge
            };
            //Dodanie utworzonej baterii do listy
            listOfBatteries.Add(battery);
        }

        //Zainicjowanie listy przykładowymi danymi
        private void InitList()
        {
            AddItemToList("Duracell", "Power", "AA", 1.6, 100, 500, 100);
            AddItemToList("Centra", "Plus+", "Aku", 12, 200, 1000, 10000);
            AddItemToList("Powerstone", "Awesome", "ABC", 2.6, 150, 900, 500);
        }

      
    }
}
