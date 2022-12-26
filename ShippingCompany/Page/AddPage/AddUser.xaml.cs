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

namespace ShippingCompany.Page.AddPage
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser 
    {
        public AddUser()
        {
            InitializeComponent();

            CmbSelectRole.Items.Add("Админ");
            CmbSelectRole.Items.Add("Клиент");
        }

        private async void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = "http://spacebaikals.ru/Zolto/create-user";
                HttpClient client = new HttpClient();

                var request = new CreateUser()
                {
                    login = TxbLogin.Text,
                    nameUser = TxbName.Text,
                    telephone = TxbTelephone.Text,
                    password = PsbPassword.Password,
                    roleName = CmbSelectRole.Text
                };

                var requestJson = JsonConvert.SerializeObject(request);
                StringContent sc = new StringContent(requestJson, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, sc);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Данные добавлены!");
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }
    }
}
