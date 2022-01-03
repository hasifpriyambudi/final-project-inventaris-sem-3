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
                MessageBox.Show("Data Berhasil Ditambahkan");
            }else{
                MessageBox.Show("Data gagal Ditambahkan");
            }
        }

        public void getData(){
            DataSet data = modelMember.getData();
            viewMember.dgDataMember.ItemsSource = data.Tables[0].DefaultView;
        }
    }
}
