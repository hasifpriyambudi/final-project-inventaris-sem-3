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
using System.Data;

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for pagePengembalian.xaml
    /// </summary>
    public partial class pagePengembalian : Page{

        controller.c_Pengembalian c_Pengembalian;
        public pagePengembalian(){
            InitializeComponent();
            // inisialisasi penggunaan controller
            c_Pengembalian = new controller.c_Pengembalian(this);
            // get list peminjaman belum dikembalikan
            c_Pengembalian.listPeminjaman();
        }
    }
}
