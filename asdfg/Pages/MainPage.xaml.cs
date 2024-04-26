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
using asdfg.StaticApp;

namespace asdfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            List<ClassUniver> list = ClassData.GetDataUni();
            ListUniver.ItemsSource = list.ToList();
            if (App.admin != null)
            {
                ProfileBtn.Visibility = Visibility.Hidden;
                RecycleBinBtn.Visibility = Visibility.Hidden;
                HistoryBtn.Visibility = Visibility.Hidden;
            }
        }

        private void ListUniver_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.univer = ListUniver.SelectedItem as ClassUniver;
            NavigationService.Navigate(new UniverPage());
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfilePage());
        }

        private void HistoryBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HistoryPage());
        }

        private void RecycleBinBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RecycleBinPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new AuthPage());
        }
    }
}
