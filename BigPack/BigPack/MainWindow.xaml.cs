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

namespace BigPack
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(new LoginPage());
        }



        private void BtnMaterial_Click(object sender, RoutedEventArgs e)
        {

                Manager.MainFrame.Navigate(new MaterialPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
        private void MainFrame_CR(object sender, EventArgs e)
        {

            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
                BtnMaterial.Visibility = Visibility.Visible;
                BtnSupplier.Visibility = Visibility.Visible;
            }
            if (master.ismaster == true)
            {
                BtnBack.Visibility = Visibility.Visible;
                BtnMaterial.IsEnabled = false;
                BtnSupplier.IsEnabled = false;
            }
            else if (admin.isadmin == true)
            {
                BtnBack.Visibility = Visibility.Visible;
                BtnMaterial.Visibility = Visibility.Visible;
                BtnSupplier.Visibility = Visibility.Visible;
            }
            else if(admin.isadmin == false && master.ismaster == false)
            {
                BtnBack.Visibility = Visibility.Hidden;
                BtnMaterial.Visibility = Visibility.Hidden;
                BtnSupplier.Visibility = Visibility.Hidden;
            }
        }

        //private void BtnLogin_Click(object sender, RoutedEventArgs e)
        //{
        //    Manager.MainFrame.Navigate(new LoginPage());
        //}

        private void BtnSupplier_Click(object sender, RoutedEventArgs e)
        {
                Manager.MainFrame.Navigate(new SupplierPage(admin.isadmin || master.ismaster));
        }
    }
}
