using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static LantaSystem.CompatibilityOfGoods;

namespace LantaSystem
{
    /// <summary>
    /// Логика взаимодействия для WindowReg.xaml
    /// </summary>
    public partial class WindowReg : Window
    {
        Users users = new Users();
        public User buffer;
        public WindowReg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<User> code = DataBase.BaseModel.User.ToList();
            var lastItem = code.Last();
            User user = new User()
            {
                ID_User = lastItem.ID_User + 1,
                Surname_User = txtSuName.Text,
                Name_User = txtName.Text,
                Login_User = txtLogin.Text,
                Password_User = txtPass.Password,
                Phone_User = txtPhon.Text,
                Address_User = txtAdres.Text,
                ID_Role = 2,
            };
            Regex checkSurName = new Regex(@"^[А-я]+$");
            Regex checkName = new Regex(@"^[А-я]+$");
            Regex checkLogin = new Regex(@"\b\w{2,10}\b");
            Regex checkPassword = new Regex(@"\b\w{2,10}\b");
            Regex checkNumberPhone = new Regex("^((\\+?7|8))\\d{10}$");
            if (((!checkName.IsMatch(txtName.Text)) || (!checkSurName.IsMatch(txtSuName.Text)) || (!checkLogin.IsMatch(txtLogin.Text)) || (!checkPassword.IsMatch(txtPass.Password)) || (!checkNumberPhone.IsMatch(txtPhon.Text))))
            {
                MessageBox.Show("Ошибка ввода");
            }
            else
            {
                bool u = true;
                foreach (var item in code)
                {
                    if (txtLogin.Text == item.Login_User)
                    {
                        u = false;
                        MessageBox.Show("Такой пользователь уже существует");
                        break;
                    }
                }
                if (u)
                {
                    try
                    {
                        DataBase.BaseModel.User.Add(user);
                        DataBase.BaseModel.SaveChanges();
                        DataBase.BaseModel = new LantaSystemEntities();
                        new WindowShop(user).Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
    }
}
