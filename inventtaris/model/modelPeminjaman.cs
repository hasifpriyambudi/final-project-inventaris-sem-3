using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model{
    class modelPeminjaman
    {
        // create object
        Koneksi temp;

        public string idBarang { get; set; }
        public string idMember { get; set; }
        public int jmlPinjam { get; set; }
        public int jmlBarang { get; set; }
        public string tglPinjam { get; set; }
        public string idAdmin { get; set; }
        public string key { get; set; }

        public modelPeminjaman()
        {
            temp = new Koneksi();
        }

        // get data list member
        public DataSet listBarang()
        {
            return temp.SelectData("SELECT id_barang, nama_barang FROM barang WHERE status_barang='1'", "barang");
        }

        // get data list member
        public DataSet listMember()
        {
            return temp.SelectData("SELECT id_member, nama_member FROM member WHERE status_member='1'", "member");
        }

        public DataSet jumlahBarang()
        {
            return temp.SelectData("SELECT jumlah_barang FROM barang WHERE id_barang='" + idBarang + "'", "barang");
        }

        public bool pinjamBarang(){
            // kurangi jumlah barang dengan jumlah peminjaman
            int jmlBarangNow = jmlBarang - jmlPinjam;
            string dataBarang = " jumlah_barang = '" + jmlBarangNow + "'";
            bool kondisiUpdateBarang = temp.Update("barang", dataBarang, "id_barang='" + idBarang + "'");

            // tambah data peminjaman
            string dataPeminjaman = "'" + idBarang + "','" + jmlPinjam + "','" + tglPinjam + "','" + idAdmin + "','" + idMember + "','0'";
            bool kondisiTambahPeminjaman = temp.Insert("peminjaman", dataPeminjaman);

            // cek jika semua kondisi benar
            if(kondisiUpdateBarang && kondisiTambahPeminjaman){
                return true;
            }else{
                return false;
            }
        }

        public DataSet getData(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT a.id_peminjaman, b.nama_member, c.nama_barang, a.jumlah, a.tanggal_peminjaman, d.nama_admin FROM peminjaman a JOIN member b ON a.id_member=b.id_member JOIN barang c ON a.id_barang=c.id_barang JOIN admin d ON a.id_admin=d.id_admin WHERE a.status='0'", "peminjaman");
            return data;
        }

        public int totalData(){
            // deklarasi variable totalMember int
            int totalPinjam;

            // cek jika public variabel key kosong
            if (key == ""){
                // jika kosong, get data dari function getData() dan menghitung row
                totalPinjam = getData().Tables[0].Rows.Count;
            }else{
                // jika tidak kosong, get data dari function searchMember() dan menghitung row
                totalPinjam = searchPeminjaman().Tables[0].Rows.Count; ;
            }

            // return variabe totalMember
            return totalPinjam;
        }

        public DataSet searchPeminjaman(){
            DataSet peminjaman = new DataSet();
            if (key == ""){
                peminjaman = getData();
            }else{
                peminjaman = temp.SelectData("SELECT a.id_peminjaman, b.nama_member, c.nama_barang, a.jumlah, a.tanggal_peminjaman, d.nama_admin FROM peminjaman a JOIN member b ON a.id_member=b.id_member JOIN barang c ON a.id_barang=c.id_barang JOIN admin d ON a.id_admin=d.id_admin WHERE (a.id_peminjaman LIKE '%" + key + "%' OR b.nama_member LIKE '%" + key + "%' OR c.nama_barang LIKE '%" + key + "%' OR a.jumlah LIKE '%" + key + "%' OR a.tanggal_peminjaman LIKE '%" + key + "%' OR d.nama_admin LIKE '%" + key + "%') AND a.status='0'", "peminjaman");
            }
            return peminjaman;
        }
    }
}
