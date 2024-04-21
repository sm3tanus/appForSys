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

namespace asdfg.Pages
{
    /// <summary>
    /// Логика взаимодействия для UniverPage.xaml
    /// </summary>
    public partial class UniverPage : Page
    {
        public UniverPage()
        {
            InitializeComponent();
            NameUni.Text = App.univer.Name;

            CostUni.Text = App.univer.Cost;
            descriptionUni.Text = App.univer.Description;
        }
    }
}
