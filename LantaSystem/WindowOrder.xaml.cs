using System;
using System.IO;
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
using System.Xml.Linq;
using LantaSystem;

namespace LantaSystem
{
    /// <summary>
    /// Логика взаимодействия для WindowOrder.xaml
    /// </summary>
    public partial class WindowOrder : Window
    {
        User user = new User();
        List<Processor> proc = new List<Processor>();
        Payment payment = new Payment();
        public WindowOrder(List<Processor> proc, User user)
        {
            this.proc = proc;
            this.user = user;
            InitializeComponent();
        }

        
        public Payment buffer;
        public WindowOrder()
        {
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
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<Payment> code = DataBase.BaseModel.Payment.ToList();
            var lastItem = code.Last();
            Payment payment = new Payment()
            {
                ID_Payment = lastItem.ID_Payment + 1,
                Card_number = Convert.ToInt32(txtKarta.Text),
                Card_code = Convert.ToInt32(txtCvv.Text),
                ID_User = user.ID_User
            };
            try
            {
                DataBase.BaseModel.Payment.Add(payment);
                DataBase.BaseModel.SaveChanges();
                DataBase.BaseModel = new LantaSystemEntitiesBD();
                MessageBox.Show("Оплата прошла успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
