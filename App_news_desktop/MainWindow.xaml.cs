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
using System.Windows.Shapes;

namespace App_news_desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ControlBarUC_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            uccontrol.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemMains":
                    usc = new App_news_desktop.UserControlN.MainNewUC(); ;
                    uccontrol.Children.Add(usc);
                    break;
                case "ItemNews":
                    usc = new App_news_desktop.UserControlN.NewsUC();
                    uccontrol.Children.Add(usc);
                    break;
                case "ItemAccounts":
                    usc = new App_news_desktop.UserControlN.AccountUC();
                    uccontrol.Children.Add(usc);
                    break;

                default:
                    break;
            }
        }
    }
}