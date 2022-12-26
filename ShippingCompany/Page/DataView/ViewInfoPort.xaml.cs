using Newtonsoft.Json;
using ShippingCompany.ClassHelper;
using ShippingCompany.Page.AddPage;
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

namespace ShippingCompany.Page.DataView
{
    /// <summary>
    /// Логика взаимодействия для ViewInfoPort.xaml
    /// </summary>
    public partial class ViewInfoPort 
    {
        public ViewInfoPort()
        {
            InitializeComponent();
            GetPort();
        }

        public async void GetPort()
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/portinfo";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _clients = JsonConvert.DeserializeObject<List<PortInfoClass>>(responseContent);
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.GoBack();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new AddPort());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/getportinfo/{TxbIdPort.Text}";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _client = JsonConvert.DeserializeObject<List<PortInfoClass>>(responseContent);
                    GridList.ItemsSource = _client.ToList();
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
