using ShippingCompany.ClassHelper;
using ShippingCompany.Page;
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
using System.Diagnostics;

namespace ShippingCompany.Page.DataView
{
    /// <summary>
    /// Логика взаимодействия для Menuuser.xaml
    /// </summary>
    public partial class Menuuser 
    {
        public Menuuser(string name, string login)
        {
            InitializeComponent();
           TxbUser.Text = "Приветствую клиент " + login + "!";
           TxbLogin.Text = "Ваш логин: " + name;
        }

        private void BtnCruise_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new ClientUser());
        }

        private void Btnback_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private void BtnCompany_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("http://spacebaikals.ru/ZoltoSite/index.html#");
        }
    }
}
