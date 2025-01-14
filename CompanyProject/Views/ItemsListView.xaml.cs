﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CompanyProject.ViewModels;

namespace CompanyProject.Views
{
    
    public partial class ItemsListView : Page
    {
        ItemListViewModel vm;
        public ItemsListView()
        {
            vm = new ItemListViewModel();
            DataContext = vm;
            InitializeComponent();
        }

        private void bResetFiltersRL_Click(object sender, RoutedEventArgs e)
        {
            vm.ResetFilters();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.FirstPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            vm.PreviousPage();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            vm.NextPage();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            vm.LastPage();
        }
    }
}
