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

        public string key { get; set; }

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

        public bool updateBarang(){
            string data = " nama_barang = '" + nama + "', jumlah_barang = '" + jumlah + "'";
            return temp.Update("barang", data, "id_barang =" + id);
        }

        public int checkPinjamBarang(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT id_barang from peminjaman WHERE id_barang='" + id + "' AND status='0'","peminjaman");
            if (data.Tables[0].Rows.Count == 0){
                return 0;
            }else{
                return 1;
            }
        }

        public bool deleteBarang(){
            string data = "status_barang='0'";
            return temp.Update("barang", data, "id_barang=" + id);
        }

        public DataSet searchBarang(){
            DataSet barang = new DataSet();
            if (key == ""){
                barang = getData();
            }else{
                barang = temp.SelectData("SELECT a.id_barang, a.nama_barang, a.jumlah_barang, a.tanggal_masuk, b.nama_admin FROM barang a JOIN admin b ON a.id_admin=b.id_admin WHERE (a.id_barang LIKE '%" + key + "%' OR a.nama_barang LIKE '%" + key + "%' OR a.jumlah_barang LIKE '%" + key + "%' OR a.tanggal_masuk LIKE '%" + key + "%' OR b.nama_admin LIKE '%" + key + "%') AND a.status_barang='1'", "barang");
            }
            return barang;
        }

        public int totalData(){
            int totalBarang;
            if (key == ""){
                totalBarang = getData().Tables[0].Rows.Count;
            }else{
                totalBarang = searchBarang().Tables[0].Rows.Count;
            }
            return totalBarang;
        }
    }
}
