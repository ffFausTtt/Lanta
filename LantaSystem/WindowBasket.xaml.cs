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

namespace LantaSystem
{
    /// <summary>
    /// Логика взаимодействия для WindowBasket.xaml
    /// </summary>
    public partial class WindowBasket : Window
    {
        List<Buying_Goods> goods = new List<Buying_Goods>();
        User user = new User();
        public WindowBasket(List<Buying_Goods> goods, User user)
        {
            this.user = user;
            //LBAllGoods.ItemsSource = goods;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new WindowProfil(user).Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new WindowShop(user).Show();
            this.Close();
        }
    }
}
