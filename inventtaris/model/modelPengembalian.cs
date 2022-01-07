using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model{
    class modelPengembalian{
        Koneksi temp;

        public modelPengembalian(){
            temp = new Koneksi();
        }

        public DataSet listPeminjaman(){
            return temp.SelectData("SELECT id_peminjaman FROM peminjaman WHERE status='0'", "peminjaman");
        }
    }
}
