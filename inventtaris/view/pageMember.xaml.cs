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

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for pageMember.xaml
    /// </summary>
    public partial class pageMember : Page{

        controller.c_Member c_Member;
        public pageMember(){
            InitializeComponent();
            c_Member = new controller.c_Member(this);
            c_Member.getData();
        }

        private void btnTambah(object sender, RoutedEventArgs e){
            c_Member.prosesTambah();
        }
    }
}
