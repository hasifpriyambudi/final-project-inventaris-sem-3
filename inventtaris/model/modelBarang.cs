using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model{
    class modelBarang{

        // load database dan template sql
        Koneksi temp;

        public string id { get; set; }
        public string nama { get; set; }
        public string jumlah { get; set; }
        public string statusBarang { get; set; }
        public string tglMasuk { get; set; }
        public string idAdmin { get; set; }

        public modelBarang(){
            temp = new Koneksi();
        }

        public bool prosesTambah(){
            string data = "'" + nama + "','" + jumlah + "','" + statusBarang + "','" + tglMasuk + "','" + idAdmin + "'";
            return temp.Insert("barang", data);
        }

        public DataSet getData(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT a.id_barang, a.nama_barang, a.jumlah_barang, a.tanggal_masuk, b.nama_admin FROM barang a JOIN admin b ON a.id_admin=b.id_admin WHERE a.status_barang='1'", "admin");
            return data;
        }
    }
}
