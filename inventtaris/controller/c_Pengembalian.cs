using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.controller{
    class c_Pengembalian{

        // create object
        model.modelPengembalian modelPengembalian;
        view.pagePengembalian viewPengembalian;

        public c_Pengembalian(view.pagePengembalian viewPengembalian){
            modelPengembalian = new model.modelPengembalian();
            this.viewPengembalian = viewPengembalian;
        }

        public void listPeminjaman(){
            DataSet listPeminjaman = modelPengembalian.listPeminjaman();
            viewPengembalian.listPeminjaman.ItemsSource = listPeminjaman.Tables[0].DefaultView;
            viewPengembalian.listPeminjaman.DisplayMemberPath = listPeminjaman.Tables[0].Columns["id_peminjaman"].ToString();
            viewPengembalian.listPeminjaman.SelectedValuePath = listPeminjaman.Tables[0].Columns["id_peminjaman"].ToString();
        }
    }
}
