using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            LoginTB.Text = App.user.Login;
            NickNameTB.Text = App.user.Name;
            BalanceTB.Text = App.user.Balance;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Add100_Click(object sender, RoutedEventArgs e)
        {
            App.user.Balance = (int.Parse(App.user.Balance) + 100).ToString();
            File.WriteAllLines(@"users.ioss", File.ReadAllLines(@"users.ioss").Where(i => i.Trim() != $"{App.user.Name};{App.user.Login};{App.user.Password};{App.user.Balance};user:".Trim()));
            using (FileStream file = new FileStream("users.ioss", FileMode.Append, FileAccess.Write))
            using (StreamWriter sr = new StreamWriter(file))
            {
                sr.Write($"{App.user.Name};{App.user.Login};{App.user.Password};{App.user.Balance};user:".Trim());
                sr.Close();
            }
            NavigationService.Navigate(new ProfilePage());
        }
    }
}
