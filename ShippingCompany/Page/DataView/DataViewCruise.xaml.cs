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
    /// Логика взаимодействия для DataViewCruise.xaml
    /// </summary>
    public partial class DataViewCruise
    {
        public DataViewCruise()
        {
            InitializeComponent();
            GetCruise();
        }

        public async void GetCruise()
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
                    GridListCruise.ItemsSource = _clients.ToList();
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

        private async void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < GridListCruise.SelectedItems.Count; i++)
                {
                    ClassCruise _cruise = GridListCruise.SelectedItems[i] as ClassCruise;
                    string url = $"http://spacebaikals.ru/Zolto/delete/{_cruise.IdCruise}";

                    HttpClient httpClient = new HttpClient();

                    var requestJson = JsonConvert.SerializeObject(_cruise);
                    StringContent sc = new StringContent(requestJson, Encoding.UTF8, "application/json");
                    var responce = await httpClient.PostAsync(url, sc);

                    if (responce.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        GetCruise();
                    }
                    else
                    {
                        MessageBox.Show("Данные обработать нельзя!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCreateCruise_Click_1(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new AddCruise());
        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/idCruise/{TxbIdCruise.Text}";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _client = JsonConvert.DeserializeObject<List<ClassCruise>>(responseContent);
                    GridListCruise.ItemsSource = _client.ToList();
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

        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            GridListCruise.SelectAll();
        }

        private void BtnNotAll_Click(object sender, RoutedEventArgs e)
        {
            GridListCruise.UnselectAll();
        }
    }
}
