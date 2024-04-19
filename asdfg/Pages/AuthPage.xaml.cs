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
using asdfg.StaticApp;

namespace asdfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void EnterB_Click(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text.Length != 0 && LoginTb.Text.Length !=0 && PasswordTb.Text.Length != 0)
            {
                StreamWriter sr = new StreamWriter("base.ioss");
                sr.Write($"\n{NameTb.Text};{LoginTb.Text};{PasswordTb.Text};user:");
                sr.WriteLine();
                sr.Close();
                NavigationService.Navigate(new MainPage());
            }
            else if (LoginTb.Text.Length != 0 && PasswordTb.Text.Length != 0)
            {
                List<ClassStatic> list = ClassData.GetData();
                var user = list.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text && x.ForWho == "user");
                if (user != null)
                {
                    NavigationService.Navigate(new MainPage());
                }
                else
                {
                    MessageBox.Show("bye");
                }
            }
            else
            {
                MessageBox.Show("Заполните");
            }

        }

        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            VisName.Visibility = Visibility.Visible;
            NameTb.Visibility = Visibility.Visible;
        }
    }
}
