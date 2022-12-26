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
    /// Логика взаимодействия для AddCruise.xaml
    /// </summary>
    public partial class AddCruise 
    {
        public AddCruise()
        {
            InitializeComponent();

            CmbPark.Items.Add("Севастополь");
            CmbPark.Items.Add("Порт-Нигерия");
            CmbPark.Items.Add("Порт-Артур");
            CmbPark.Items.Add("Севастополь");
            CmbPark.Items.Add("Порт-Кристиану");



            CmbShip.Items.Add("Линкор");
            CmbShip.Items.Add("Танкер");
            CmbShip.Items.Add("Фрегат");
            CmbShip.Items.Add("Лайнер");
            CmbShip.Items.Add("Сухогруз");
        }

        private async void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = "http://spacebaikals.ru/Zolto/create-cruise";
                HttpClient client = new HttpClient();

                var request = new CreateCruise()
                {
                    NameCruise = TxbName.Text,
                    DateCruise = TxbDate.Text,
                    Ship = CmbShip.Text,
                    Parking = CmbPark.Text,
                    TimeSailing = TxbTime.Text,
                    Price = TxbPrice.Text,
                    Occupied = TxbOccupied.Text
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
