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

namespace asdfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для RecycleBinPage.xaml
    /// </summary>
    public partial class RecycleBinPage : Page
    {
        public RecycleBinPage()
        {
            InitializeComponent();
        }

        private void ListUniver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new ItemInRecycleBinPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
