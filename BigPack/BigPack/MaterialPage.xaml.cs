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
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {

        public MaterialPage()
        {
            InitializeComponent();
            //var currentMaterials = PACKEntities.GetContext().Материал.ToList();
            //LViewMaterials.ItemsSource = currentMaterials.OrderBy(p => p.Тип_материала).ToList();

            ComboboxFilter.ItemsSource = new List<string> { "Все типы", "Гранулы", "Краски", "Нитки" };
            ComboboxFilter.SelectedIndex = 0;

            ComboboxSort.ItemsSource = new List<string> { "Все типы", "По названию", "Количеству на складе", "Минимальное количество в упаковке" };
            ComboboxSort.SelectedIndex = 0;
            UpdateMaterials();
        }
        private void UpdateMaterials()
        {
            var _currentMaterials = PACKEntities.GetContext().Материал.ToList();


            if (ComboboxFilter.SelectedIndex > 0)
            {
                _currentMaterials = _currentMaterials.Where(p => p.Тип_материала.Contains(ComboboxFilter.SelectedItem.ToString())).ToList();
            }

            _currentMaterials = _currentMaterials.Where(p => p.Наименование.ToLower().Contains(TBoxSerch.Text.ToLower())).ToList();

            if (ComboboxSort.SelectedIndex > 0)
            {
                //_currentMaterials = _currentMaterials.Where(p => (bool)p.IsActual).ToList(); 

                if (ComboboxSort.SelectedItem.ToString() == "По названию")
                {
                    _currentMaterials = _currentMaterials.OrderBy(p => p.Наименование).ToList();
                }
                else if (ComboboxSort.SelectedItem.ToString() == "Количеству на складе")
                {
                    _currentMaterials = _currentMaterials.OrderBy(p => p.Количество_на_складе).ToList();
                }
                else if (ComboboxSort.SelectedItem.ToString() == "Минимальное количество в упаковке")
                {
                    _currentMaterials = _currentMaterials.OrderBy(p => p.Минимальное_количество).ToList();
                }

            }

            LViewMaterials.ItemsSource = _currentMaterials;
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateMaterials();
        }


        private void ComboBoxFilte_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMaterials();
        }

        private void ComboBoxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateMaterials();
        }
    }
}
