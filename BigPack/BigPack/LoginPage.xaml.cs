using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace BigPack
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        PACKEntities db = new PACKEntities();
        private user _users = new user();
        user authuser = null;
        user adminunser = null;
        private string TypeUser;

        public static int TypeID { get; set; }

        public LoginPage()
        {
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            var authuser = db.users.FirstOrDefault(x => x.login == textBox_login.Text && x.password == passwordBox_password.Password);
            var adminuser = db.users.FirstOrDefault(x => x.login == textBox_login.Text && x.type_user == "admin");
            var masteruser = db.users.FirstOrDefault(x => x.login == textBox_login.Text && x.type_user == "master");
            GetHash(passwordBox_password.Password);
            if (authuser != null)
            {
                if (adminuser != null)
                {
                    MessageBox.Show("Вы вошли как администратор");
                    master.ismaster = false;
                    admin.isadmin = true;
                    Manager.MainFrame.Navigate(new MainPage());
                }
                else if (masteruser != null)
                {
                    MessageBox.Show("Вы вошли как мастер");
                    Manager.MainFrame.Navigate(new MasterPage(null));
                    master.ismaster = true;
                    admin.isadmin = false;
                }
                else
                {
                    MessageBox.Show("Вы вошли как пользователь");
                    master.ismaster = false;
                    admin.isadmin = false;
                    Manager.MainFrame.Navigate(new MainPage());
                }
            }
            else
            {
                MessageBox.Show("Ошибка!!!\nВведите данные");
            }
        }
    }
}
