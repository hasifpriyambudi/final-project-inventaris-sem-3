using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace inventtaris.controller{
    class c_Member{

        // deklarasi objek
        model.modelMember modelMember;
        view.pageMember viewMember;
        

        public c_Member(view.pageMember viewMember){
            modelMember = new model.modelMember();
            this.viewMember= viewMember;
        }

        public void prosesTambah(){
            modelMember.nama = viewMember.namaMember.Text;
            modelMember.email = viewMember.emailMember.Text;
            modelMember.nomor = viewMember.nomorMember.Text;
            modelMember.alamat = viewMember.alamatMember.Text;
            modelMember.id_admin = model.cekLogin.idAdmin;
            bool result = modelMember.prosesTambah();
            if (result){
                getData();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }else{
                MessageBox.Show("Data gagal Ditambahkan");
            }
        }

        public void updateMember(){
            modelMember.id = viewMember.idMember.Text;
            modelMember.nama = viewMember.namaMember.Text;
            modelMember.email = viewMember.emailMember.Text;
            modelMember.nomor = viewMember.nomorMember.Text;
            modelMember.alamat = viewMember.alamatMember.Text;
            modelMember.id_admin = model.cekLogin.idAdmin;
            bool result = modelMember.updateMember();
            if (result){
                getData();
                MessageBox.Show("Data Berhasil Diupdate");
            }else{
                MessageBox.Show("Data gagal Diupdate");
            }
        }

        public void getData(){
            DataSet data = modelMember.getData();
            viewMember.dgmember.ItemsSource = data.Tables[0].DefaultView;
        }

        public void deleteMember(){
            modelMember.id = viewMember.idMember.Text;
            bool result = modelMember.deleteMember();
            if (result){
                getData();
                MessageBox.Show("Member Berhasil DIhapus");
            }else{
                MessageBox.Show("Data gagal Diupdate");
            }
        }


        // function untuk mencari data
        public void searchMember(){
            // set variable global key pada model
            modelMember.key = viewMember.keySearch.Text;
            
            // get search data dari modelMember
            DataSet data = modelMember.searchMember();
            
            // setting datagrid dengan data search terbaru
            viewMember.dgmember.ItemsSource = data.Tables[0].DefaultView;

            // menampilkan total data terbaru
            totalData();
        }

        // function untuk menampilkan total data
        public void totalData(){
            // get total data dari model
            int totalMember = modelMember.totalData();
            
            // menampilkan total data ke view
            viewMember.lblTotalData.Content = totalMember;
        }
    }
}
