using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace asdfg.Pages
{
    public partial class UniverPage : Page
    {
        public UniverPage()
        {
            InitializeComponent();
            NameUni.Text = App.univer.Name;
            CostUni.Text = App.univer.Cost;
            descriptionUni.Text = App.univer.Description;
            if (App.admin == null)
            {
                NameUni.IsReadOnly = true;
                CostUni.IsReadOnly = true;
                descriptionUni.IsReadOnly = true;
                SaveBt.Visibility = Visibility.Hidden;
            }
        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines(@"service.ioss", File.ReadAllLines(@"service.ioss").Where(i => i.Trim() != $"{App.univer.Name};{App.univer.Cost};{App.univer.Description};univer:".Trim()));
            using (FileStream file = new FileStream("service.ioss", FileMode.Append, FileAccess.Write))
            using (StreamWriter sr = new StreamWriter(file))
            {
                sr.Write($"{NameUni.Text};{CostUni.Text};{descriptionUni.Text};univer:".Trim());
                sr.Close();
            }
            NavigationService.Navigate(new MainPage());

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}