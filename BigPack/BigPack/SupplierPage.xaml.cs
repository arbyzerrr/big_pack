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

namespace BigPack
{
    /// <summary>
    /// Логика взаимодействия для SupplierPage.xaml
    /// </summary>
    public partial class SupplierPage : Page
    {
        public SupplierPage(bool isadmin)
        {
            InitializeComponent();
            if (isadmin == false)
            {
                BtnAdd.Visibility = Visibility.Hidden;
                BtnDelete.Visibility = Visibility.Hidden;
                
            }
            DGridSupplier.ItemsSource = PACKEntities.GetContext().Поставщик.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SupplierAddEditPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var supplierForRemoving = DGridSupplier.SelectedItems.Cast<Поставщик>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить {supplierForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PACKEntities.GetContext().Поставщик.RemoveRange(supplierForRemoving);
                    PACKEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridSupplier.ItemsSource = PACKEntities.GetContext().Поставщик.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SupplierAddEditPage((sender as Button).DataContext as Поставщик));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                PACKEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridSupplier.ItemsSource = PACKEntities.GetContext().Поставщик.ToList();
            }
        }
    }
}
