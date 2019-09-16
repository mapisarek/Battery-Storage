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

namespace BatteryStorage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Inicjalizacja widoków w oknie
        StartView startView;
        StorageView storageView;

        public MainWindow()
        {
            //Utworzenie nowego obiektu widoku
            startView = new StartView();
            InitializeComponent();
            //Przypisanie zawartości okna
            DataContext = startView;
            //Zmiana zawartości okna na widok magazynu po wybraniu przycisku Start
            this.startView.StartApp += new EventHandler(startAppView);
        }

        //Utworzenie nowego widoku i przypisanie zawartości okna do niego
        public void startAppView(object sender, EventArgs e)
        {
            storageView = new StorageView();
            DataContext = storageView;
        }
    }
}
