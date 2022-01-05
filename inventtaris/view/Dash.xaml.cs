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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for Dash.xaml
    /// </summary>
    public partial class Dash : Window{
        public Dash(){
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e){
            FrameMain.Navigate(new view.pageHome());
        }

        private void menuMember_MouseDown(object sender, MouseButtonEventArgs e){
            FrameMain.Navigate(new view.pageMember());
        }

        private void menuBarang_MouseDown(object sender, MouseButtonEventArgs e){
            FrameMain.Navigate(new view.pageBarang());
        }

        private void menuPeminjaman_MouseDown(object sender, MouseButtonEventArgs e)
        {
            FrameMain.Navigate(new view.pagePeminjaman());
        }

        private void menuPengembalian_MouseDown(object sender, MouseButtonEventArgs e){
            FrameMain.Navigate(new view.pagePengembalian());
        }

        private void menuLogout_MouseDown(object sender, MouseButtonEventArgs e){
            login login= new login();
            login.Show();
            this.Close();
        }

        private void menuAdmin_MouseDown(object sender, MouseButtonEventArgs e){
            FrameMain.Navigate(new view.pageAdmin());
        }
    }
}
