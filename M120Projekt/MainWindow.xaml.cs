using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace M120Projekt
{
    using UserControls;
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static Label Label { get; set; }

        public static Grid UCContainer { get; set; }
        public static Button BackButton { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            // Wichtig!
            Data.Global.context = new Data.Context();
            Label = lblHeader;
            UCContainer = usercontrolContainer;
            UCContainer.Children.Add(new Listenansicht());
            //Aufruf diverse APIDemo Methoden
            //API.DemoACreate();
            //APIDemo.DemoACreateKurz();
            //API.DemoARead();
            //API.DemoAUpdate();
            //API.DemoARead();
            //APIDemo.DemoADelete();
        }

        private void BtnEvent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
