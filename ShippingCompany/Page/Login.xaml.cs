using Newtonsoft.Json;
using ShippingCompany.ClassHelper;
using ShippingCompany.Page.DataView;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            Navigator.ViewDate.Navigate(new Registration());
        }

        private async void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string url = $"http://spacebaikals.ru/Zolto/auth?login={TxbLogin.Text}&password={PsbBox.Password}";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var _signIn = JsonConvert.DeserializeObject<SignIn>(responseContent);

                    switch (_signIn.RoleUser)
                    {
                        case "Админ":
                            MessageBox.Show("Ваша роль в этом приложении " + _signIn.RoleUser + "!");
                            Navigator.ViewDate.Navigate(new MenuAdmin(TxbLogin.Text, TxbName.Text));
                            break;

                        case "Клиент":
                            MessageBox.Show("Ваша роль в этом приложении " + _signIn.RoleUser + "!");
                            Navigator.ViewDate.Navigate(new Menuuser(TxbLogin.Text, TxbName.Text));
                            break;

                        default:
                            MessageBox.Show("Неверная обработка данных");
                            break;
                    }
                }
            }
            catch (Exception er)
            {

                er.Message.ToString();
            }
        }
    }
}

