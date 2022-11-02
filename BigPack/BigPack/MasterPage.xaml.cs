﻿using System;
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
    /// Логика взаимодействия для MasterPage.xaml
    /// </summary>
    public partial class MasterPage : Page
    {
        private График_смены _currentMaster = new График_смены();
        public MasterPage(График_смены selectedMaster)
        {
            InitializeComponent();
            if (selectedMaster != null)
                _currentMaster = selectedMaster;

            DataContext = _currentMaster;
            ComboMaster.ItemsSource = PACKEntities.GetContext().Цех.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentMaster.Цех == null)
                errors.AppendLine("Выберите цех");
            if (_currentMaster.ID_мастера == null)
                errors.AppendLine("Введите ID мастера");


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentMaster.ID == 0)
                PACKEntities.GetContext().График_смены.Add(_currentMaster);

            try
            {
                PACKEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
