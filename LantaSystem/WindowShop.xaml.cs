﻿using System;
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
    /// Логика взаимодействия для WindowShop.xaml
    /// </summary>
    public partial class WindowShop : Window
    {
       User user = new User();
        public WindowShop(User user)
        {
            this.user = user;
            InitializeComponent();
            InitializeComponent();
        }
    }
}