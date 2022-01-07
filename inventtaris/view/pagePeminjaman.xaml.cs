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
using System.Text.RegularExpressions;
using System.Data;

namespace inventtaris.view{
    /// <summary>
    /// Interaction logic for pagePeminjaman.xaml
    /// </summary>
    public partial class pagePeminjaman : Page{
        // create object
        controller.c_Peminjaman c_Peminjaman;
        public pagePeminjaman(){
            InitializeComponent();
            // inisialisasi penggunaan controller
            c_Peminjaman = new controller.c_Peminjaman(this);
            // load list barang pada combobox barang
            c_Peminjaman.listBarang();
            // load list member pada ombobox member
            c_Peminjaman.listMember();
            // get data peminjaman
            c_Peminjaman.getData();
            // get total data peminjaman
            c_Peminjaman.totalData();
        }

        // function untuk check input kolom jumlah only integer
        private void nomorMember_PreviewTextInput(object sender, TextCompositionEventArgs e){
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void listBarang_SelectionChanged(object sender, SelectionChangedEventArgs e){
            if (listBarang.SelectedItem != null){
                DataRowView oDataRowView = listBarang.SelectedItem as DataRowView;
                c_Peminjaman.jumlahBarang(oDataRowView["id_barang"].ToString());
            }else{
                jumlahBarang.Text = "";
            }
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e){
            c_Peminjaman.pinjamBarang();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){
            c_Peminjaman.searchBarang();
        }
    }
}
