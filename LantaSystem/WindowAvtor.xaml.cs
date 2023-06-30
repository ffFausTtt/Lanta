using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LantaSystem
{
    /// <summary>
    /// Логика взаимодействия для WindowAvtor.xaml
    /// </summary>
    public partial class WindowAvtor : Window
    {
        //Product prd = new Product();
        public User buffer;
        public WindowAvtor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = DataBase.BaseModel.User.FirstOrDefault(x => x.Login_User == txtLogin.Text && x.Password_User == txtPass.Password);
            if (user != null)
            {
                new WindowShop(user).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует. Попробуйте снова или зарегистрируйтесь.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new WindowReg().Show();
            this.Close();
        }
    }
}
