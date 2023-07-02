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
using System.Windows.Shapes;
using static LantaSystem.CompatibilityOfGoods;

namespace LantaSystem
{
    /// <summary>
    /// Логика взаимодействия для WindowProfil.xaml
    /// </summary>
    public partial class WindowProfil : Window
    {
        public User buffer;
        public User changeuser;
        Users users = new Users();
        User user = new User();
        public WindowProfil(User ID_User)
        {
            InitializeComponent();
            DataContext = ID_User;
            buffer = ID_User;
            changeuser = ID_User;
            user = ID_User;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<User> code = DataBase.BaseModel.User.ToList();

            changeuser.Surname_User = txtSuName.Text;
            changeuser.Name_User = txtName.Text;
            changeuser.Login_User = txtLogin.Text;
            changeuser.Password_User = txtPass.Text;
            changeuser.Phone_User = txtPhon.Text;
            changeuser.Address_User = txtAdres.Text;
            changeuser.ID_Role = 2;
            DataBase.BaseModel.SaveChanges();
            users.usr = users.newuser();
            MessageBox.Show("Изменения сохранены");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<User> code = DataBase.BaseModel.User.ToList();
            User user = new User()
            {
                Surname_User = txtSuName.Text,
                Name_User = txtName.Text,
                Login_User = txtLogin.Text,
                Password_User = txtPass.Text,
                Phone_User = txtPhon.Text,
                Address_User = txtAdres.Text,
                ID_Role = 2,
            };
            DataBase.BaseModel = new LantaSystemEntitiesBD();
            new WindowShop(user).Show();
            this.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new WindowAvtor().Show();
            this.Close();
        }
    }
}
