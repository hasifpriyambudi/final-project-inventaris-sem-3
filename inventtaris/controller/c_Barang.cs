using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace inventtaris.controller{
    class c_Barang{

        //deklarasi objek
        model.modelBarang modelBarang;
        view.pageBarang viewBarang;

        public c_Barang(view.pageBarang viewBarang){
            modelBarang = new model.modelBarang();
            this.viewBarang = viewBarang;
        }

        public void prosesTambah(){
            DateTime today = DateTime.Now;
            modelBarang.nama = viewBarang.namaBarang.Text;
            modelBarang.jumlah = viewBarang.jumlahBarang.Text;
            modelBarang.statusBarang = "1";
            modelBarang.tglMasuk = today.ToString("yyyy-MM-dd hh:mm:ss");
            modelBarang.idAdmin = model.cekLogin.idAdmin;
            bool result = modelBarang.prosesTambah();
            if (result){
                getData();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }else{
                MessageBox.Show("Data gagal Ditambahkan");
            }
        }

        public void getData(){
            DataSet data = modelBarang.getData();
            viewBarang.dgBarang.ItemsSource = data.Tables[0].DefaultView;
        }

        public void updateBarang(){
            modelBarang.id = viewBarang.idBarang.Text;
            modelBarang.nama = viewBarang.namaBarang.Text;
            modelBarang.jumlah = viewBarang.jumlahBarang.Text;
            bool result = modelBarang.updateBarang();
            if (result){
                getData();
                MessageBox.Show("Data Berhasil Diupdate");
            }else{
                MessageBox.Show("Data gagal Diupdate");
            }
        }

        public void deleteBarang(){
            modelBarang.id = viewBarang.idBarang.Text;
            int checkPeminjamanBarang = modelBarang.checkPinjamBarang();
            if (checkPeminjamanBarang == 0){
                bool result = modelBarang.deleteBarang();
                getData();
                MessageBox.Show("Barang Berhasil Dihapus");
            }
            else{
                MessageBox.Show("Barang Tidak Bisa Dihapus, Karena Peminjaman Masih Ada");
            }
        }

        public void searchBarang(){
            modelBarang.key = viewBarang.keySearch.Text;
            DataSet data = modelBarang.searchBarang();
            viewBarang.dgBarang.ItemsSource = data.Tables[0].DefaultView;
            totalData();
        }

        public void totalData(){
            int totalBarang = modelBarang.totalData();
            viewBarang.lblTotalData.Content = totalBarang;
        }
    }
}
