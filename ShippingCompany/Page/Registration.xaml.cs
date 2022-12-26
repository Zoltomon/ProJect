using Newtonsoft.Json;
using ShippingCompany.ClassHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace ShippingCompany.Page
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration 
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (TxbLogin.Text == "" || TxbName.Text == "" || TxbPhone.Text == "" || PsbBox.Password == "" || TxbSur.Text == "")
            {
                MessageBox.Show("Введите данные в незаполненные таблицы!");
            }
            else
            {
                try
                {
                    string url = "http://spacebaikals.ru/Zolto/create-user";
                    HttpClient client = new HttpClient();

                    var request = new CreateUser()
                    {
                        login = TxbLogin.Text,
                        nameUser = TxbName.Text,
                        surnameUser = TxbSur.Text,
                        patronomicUser = TxbPatr.Text,
                        telephone = TxbPhone.Text,
                        password = PsbBox.Password,
                        roleName = "Клиент",

                    };

                    var requestJson = JsonConvert.SerializeObject(request);
                    StringContent sc = new StringContent(requestJson, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, sc);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Успешно пройдена регистрация!");
                    }
                    else
                    {
                        MessageBox.Show("Сбой в системе!");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }
    }
}
