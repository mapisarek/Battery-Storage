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

        //Usunięcie przedmiotów z listy
        public void DeleteItems()
        {
            //Utworzenie tymczasowej listy która przechowuje wybrane rekordy
            List<Battery> tempItemsToDelete = new List<Battery>();

            //Dodanie obiektów do tymczasowej listy
            foreach (var item in listOfBatteries)
            {
                if (item.IsSelected)
                {
                    tempItemsToDelete.Add(item);
                }
            }
            //Przeiterowanie przez rekordy znajdujące się w tymczasowej liście i usunięcie ich z ObservableCollection
            foreach (var item in tempItemsToDelete)
            {
                listOfBatteries.Remove(item);
            }
        }


        //Metoda sortująca liste
        public void SortListBy(int index)
        {
            //W zależności od otrzymanego indeksu wybranie konkretnego sortowania
            switch (index)
            {
                case 0:
                    //Usunięcie sortowania jeżeli jest wybrane
                    ItemsView.SortDescriptions.Clear();
                    //Dodanie sortowania według parametru, tutaj akurat Name
                    ItemsView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                    break;
                case 1:

                    ItemsView.SortDescriptions.Clear();
                    ItemsView.SortDescriptions.Add(new SortDescription("Model", ListSortDirection.Ascending));

                    break;
                case 2:
                    ItemsView.SortDescriptions.Clear();
                    ItemsView.SortDescriptions.Add(new SortDescription("Type", ListSortDirection.Ascending));
                    break;
                case 3:
                    break;
            }
        }


       
    }
}
