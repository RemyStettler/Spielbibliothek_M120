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

namespace M120Projekt.UserControls
{
    /// <summary>
    /// Interaktionslogik für Einzelansicht.xaml
    /// </summary>
    public partial class Einzelansicht : UserControl
    {
        public Einzelansicht()
        {
            InitializeComponent();
            MainWindow.Label.Content = "Einzelansicht";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Ändernansicht());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult dialog = MessageBox.Show("Dieses Element wirklich Löschen?", "Endgültig löschen?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(dialog == MessageBoxResult.Yes)
            {
                throw new NotImplementedException();
                MainWindow.UCContainer.Children.Remove(this);
                MainWindow.UCContainer.Children.Add(new Listenansicht());
            }
        }
    }
}
