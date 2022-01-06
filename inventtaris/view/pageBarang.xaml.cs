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
    /// Interaction logic for pageBarang.xaml
    /// </summary>
    public partial class pageBarang : Page{

        controller.c_Barang c_Barang;
        public pageBarang(){
            InitializeComponent();
            c_Barang = new controller.c_Barang(this);
            c_Barang.getData();
            c_Barang.totalData();
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e){
            c_Barang.prosesTambah();
        }

        private void dgBarang_SelectionChanged(object sender, SelectionChangedEventArgs e){
            if (dgBarang.SelectedItem != null){
                object item = dgBarang.SelectedItem;
                idBarang.Text = (dgBarang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                namaBarang.Text = (dgBarang.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                jumlahBarang.Text = (dgBarang.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                // enable button update
                buttonUpdate.IsEnabled = true;
                buttonTambah.IsEnabled = false;
                buttonCancel.IsEnabled = true;
                buttonDelete.IsEnabled = true;
            }
            else
            {
                cancel();
            }
        }

        private void cancel(){
            idBarang.Text = "";
            namaBarang.Text = "";
            jumlahBarang.Text = "";
            buttonUpdate.IsEnabled = false;
            buttonTambah.IsEnabled = true;
            buttonCancel.IsEnabled = false;
            buttonDelete.IsEnabled = false;
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e){
            c_Barang.deleteBarang();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e){
            cancel();
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e){
            c_Barang.updateBarang();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e){
            c_Barang.searchBarang();
        }
    }
}
