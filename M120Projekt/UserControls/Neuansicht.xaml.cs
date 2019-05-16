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
    using Helpers;
    /// <summary>
    /// Interaktionslogik für Neuansicht.xaml
    /// </summary>
    public partial class Neuansicht : UserControl
    {
        public Neuansicht()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.UCContainer.Children.Remove(this);
            MainWindow.UCContainer.Children.Add(new Listenansicht());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FelderLeeren();
        }

        private void FelderLeeren()
        {
            datePicker.SelectedDate = null;
            datePicker.DisplayDate = DateTime.Today;
            txtMindestalter.Clear();
            txtName.Clear();
            txtPreis.Clear();
            txtPublisher.Clear();
            txtBewertung.Clear();
            checkSteam.IsChecked = false;
        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (Validation.NameValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
            }
            
        }

        private void TxtPublisher_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (Validation.PublisherValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
            }
        }

        private void TxtMindestalter_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (Validation.MindestalterValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
            }
        }

        private void TxtPreis_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (Validation.PreisValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
            }
        }

        private void TxtBewertung_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (Validation.BewertungValidieren(txt.Text))
            {
                txt.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                txt.BorderBrush = Brushes.Red;
            }
        }
    }
}
