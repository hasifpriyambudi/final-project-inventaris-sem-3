using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace inventtaris.controller{
    class c_Peminjaman{

        // create object
        model.modelPeminjaman modelPeminjaman;
        view.pagePeminjaman viewPeminjaman;

        public c_Peminjaman(view.pagePeminjaman viewPeminjaman){
            modelPeminjaman = new model.modelPeminjaman();
            this.viewPeminjaman = viewPeminjaman;
        }

        public void listBarang(){
            DataSet listBarang = modelPeminjaman.listBarang();
            viewPeminjaman.listBarang.ItemsSource = listBarang.Tables[0].DefaultView;
            viewPeminjaman.listBarang.DisplayMemberPath = listBarang.Tables[0].Columns["nama_barang"].ToString();
            viewPeminjaman.listBarang.SelectedValuePath = listBarang.Tables[0].Columns["id_barang"].ToString();
        }
        
        public void listMember(){
            DataSet listMember = modelPeminjaman.listMember();
            viewPeminjaman.listMember.ItemsSource = listMember.Tables[0].DefaultView;
            viewPeminjaman.listMember.DisplayMemberPath = listMember.Tables[0].Columns["nama_member"].ToString();
            viewPeminjaman.listMember.SelectedValuePath = listMember.Tables[0].Columns["id_member"].ToString();
        }

        // get jumlah barang
        public void jumlahBarang(string idBarang){
            modelPeminjaman.idBarang = idBarang;
            DataSet jumlahBarang = modelPeminjaman.jumlahBarang();
            viewPeminjaman.jumlahBarang.Text = jumlahBarang.Tables[0].Rows[0][0].ToString();
        }

        public void pinjamBarang(){
            int jumlahBarang = Int16.Parse(viewPeminjaman.jumlahBarang.Text);
            int jumlahPinjam = Int16.Parse(viewPeminjaman.jumlahPinjam.Text);
            if(viewPeminjaman.listBarang.SelectedIndex<0 || viewPeminjaman.listMember.SelectedIndex < 0 || viewPeminjaman.jumlahBarang.Text == "" || viewPeminjaman.jumlahPinjam.Text == ""){
                MessageBox.Show("Isi Semua Form dengan Benar");
            }else{
                if (jumlahBarang < jumlahPinjam){
                    MessageBox.Show("Jumlah Peminjaman Terlalu Banyak");
                    viewPeminjaman.jumlahPinjam.Text = "";
                }else{
                    // get selected list member from combobox
                    DataRowView selectedListMember = viewPeminjaman.listMember.SelectedItem as DataRowView;
                    string idMember = selectedListMember["id_member"].ToString();

                    // get selected list barang from combobox
                    DataRowView selectedListBarang = viewPeminjaman.listBarang.SelectedItem as DataRowView;
                    string idBarang = selectedListBarang["id_barang"].ToString();

                    // get tanggal hari ini
                    DateTime today = DateTime.Now;

                    // setting global variabel modelPeminjaman
                    modelPeminjaman.idBarang = idBarang;
                    modelPeminjaman.idMember = idMember;
                    modelPeminjaman.jmlPinjam = jumlahPinjam;
                    modelPeminjaman.jmlBarang = jumlahBarang;
                    modelPeminjaman.tglPinjam = today.ToString("yyyy-MM-dd hh:mm:ss");
                    modelPeminjaman.idAdmin = model.cekLogin.idAdmin;
                    
                    // eksekusi function pinjamBarang di modelPeminjaman
                    bool result = modelPeminjaman.pinjamBarang();

                    // cek eksekusi function pinnjamBarang berjalan atau tidak
                    if (result){
                        MessageBox.Show("Peminjaman Berhasil");
                        clearForm();
                    }else{
                        MessageBox.Show("Peminjaman Gagal");
                        clearForm();
                    }
                }
            }
        }

        // function clear form peminjaman
        public void clearForm(){
            viewPeminjaman.listBarang.SelectedIndex = -1;
            viewPeminjaman.listMember.SelectedIndex = -1;
            viewPeminjaman.jumlahBarang.Text = "";
            viewPeminjaman.jumlahPinjam.Text = "";
        }

        // function get data peminjaman
        public void getData(){
            DataSet data = modelPeminjaman.getData();
            viewPeminjaman.dgPeminjaman.ItemsSource = data.Tables[0].DefaultView;
        }

        // total data peminjaman
        public void totalData(){
            int totalBarang = modelPeminjaman.totalData();
            viewPeminjaman.lblTotalData.Content = totalBarang;
        }

        // search peminjaman
        public void searchBarang(){
            modelPeminjaman.key = viewPeminjaman.keySearch.Text;
            DataSet data = modelPeminjaman.searchPeminjaman();
            viewPeminjaman.dgPeminjaman.ItemsSource = data.Tables[0].DefaultView;
            totalData();
        }
    }
}