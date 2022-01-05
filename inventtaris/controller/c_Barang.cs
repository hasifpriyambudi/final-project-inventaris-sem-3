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
    }
}
