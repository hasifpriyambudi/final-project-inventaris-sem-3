using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inventtaris.view
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window{
        controller.C_cekLogin cLogin;
        public login(){
            InitializeComponent();
            cLogin = new controller.C_cekLogin(this);
        }

        private void btnLoginProses(object sender, RoutedEventArgs e){
            cLogin.login();
        }
    }
}
