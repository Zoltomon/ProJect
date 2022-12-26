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
    /// Логика взаимодействия для ClientUser.xaml
    /// </summary>
    public partial class ClientUser
    {
        public ClientUser()
        {
            InitializeComponent();
            GetUserCruise();
        }

        public async void GetUserCruise()
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/dataCruise";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _clients = JsonConvert.DeserializeObject<List<ClassCruise>>(responseContent);
                    GridList.ItemsSource = _clients.ToList();
                }
                else
                {
                    MessageBox.Show("Данные обработать нельзя!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Билет успешно приобретён");
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/idCruise/{TxbNameCruise.Text}";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _client = JsonConvert.DeserializeObject<List<ClassCruise>>(responseContent);
                    GridList.ItemsSource = _client.ToList();
                }
                else
                {
                    MessageBox.Show("Такого рейса нет!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private async void BtnVeryMoney_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/money";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _client = JsonConvert.DeserializeObject<List<ClassCruise>>(responseContent);
                    GridList.ItemsSource = _client.ToList();
                    
                }
                else
                {
                    MessageBox.Show("Не обработано!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
