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
            if (RegB.Visibility == Visibility.Hidden)
            {
                if (NameTb.Text.Length >= 6 && LoginTb.Text.Length >= 6  && PasswordTb.Text.Length >= 6)
                {
                    using (FileStream file = new FileStream("base.ioss", FileMode.Append, FileAccess.Write))
                    using (StreamWriter sr = new StreamWriter(file))
                    {
                        sr.WriteLine();
                        sr.Write($"{NameTb.Text};{LoginTb.Text};{PasswordTb.Text};user:");
                        sr.Close();
                    }
                    NavigationService.Navigate(new MainPage());
                }
                else
                {
                    MessageBox.Show("Имя, логин и пароль должны быть не менее 6 символов!");
                }
            }
            else
            {
                if (LoginTb.Text.Length != 0 && PasswordTb.Text.Length != 0)
                {
                    List<ClassStatic> list = ClassData.GetData();
                    var user = list.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text && x.ForWho == "user");
                    App.admin = list.FirstOrDefault(x => x.Login == LoginTb.Text && x.Password == PasswordTb.Text && x.ForWho == "admin");
                    if (user != null || App.admin != null)
                    {
                        NavigationService.Navigate(new MainPage());
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
        }

        private void RegB_Click(object sender, RoutedEventArgs e)
        {
            VisName.Visibility = Visibility.Visible;
            NameTb.Visibility = Visibility.Visible;
            RegB.Visibility = Visibility.Hidden;
        }
    }
}
