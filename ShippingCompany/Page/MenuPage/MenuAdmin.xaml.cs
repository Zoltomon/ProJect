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
using ShippingCompany.ClassHelper;
using ShippingCompany.Page;
using ShippingCompany.Page.DataView;

namespace ShippingCompany.Page
{
    /// <summary>
    /// Логика взаимодействия для MenuAdmin.xaml
    /// </summary>
    public partial class MenuAdmin
    {
        public MenuAdmin(string login, string name)
        {
            InitializeComponent();
            TxbUser.Text = "Приветствую вас в админ панеле пользователь под именем " + name + "!";
            TxbLogin.Text = "Ваш логин: " + login;
        }
        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new ViewData());
        }

        private void BtnCruise_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new DataViewCruise());
        }


        private void BtnPort_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new ViewInfoPort());
        }

        private void BtnShip_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new ViewInfoShip());
        }
    }
}
