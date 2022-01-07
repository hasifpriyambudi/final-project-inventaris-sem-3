using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace inventtaris.model
{
    class modelMember{
        Koneksi temp;

        public string id { get; set; }
        public string nama{ get; set; }
        public string email { get; set; }
        public string nomor { get; set; }
        public string alamat { get; set; }
        public string status_member { get; set; }
        public string id_admin { get; set; }
        public string key { get; set; }

        public modelMember(){
            temp = new Koneksi();
        }

        public bool prosesTambah(){
            string data = "'" + nama+ "','" + email+"','"+nomor+"','"+alamat+"','"+id_admin+"','1'";
            return temp.Insert("member", data);
        }

        public DataSet getData(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT a.id_member, a.nama_member, a.email, a.nomor, a.alamat, b.nama_admin FROM member a JOIN admin b ON a.id_admin=b.id_admin WHERE a.status_member='1'", "admin");
            return data;
        }

        public bool updateMember(){
            string data = " nama_member = '" + nama + "', email = '" + email + "', nomor= '" + nomor + "', alamat='" + alamat + "', id_admin='" + id_admin+"'";
            return temp.Update("member", data, "id_member ="+id);
        }

        public bool deleteMember(){
            string data = "status_member='0'";
            return temp.Update("member", data, "id_member=" + id);
        }

        public DataSet searchMember(){
            DataSet member = new DataSet();
            if (key == ""){
                member = getData();
            }else{
                member = temp.SelectData("SELECT a.id_member, a.nama_member, a.email, a.nomor, a.alamat, b.nama_admin FROM member a JOIN admin b ON a.id_admin=b.id_admin WHERE (a.nama_member LIKE '"+key+ "' OR a.email LIKE '%" + key + "%' OR a.nomor LIKE '%" + key + "%' OR a.alamat LIKE '%" + key + "%' OR b.nama_admin LIKE '%" + key + "%') AND a.status_member='1'", "admin");
            }
            return member;
        }

        // model untuk menampilkan total data
        public int totalData(){
            // deklarasi variable totalMember int
            int totalMember;
            
            // cek jika public variabel key kosong
            if (key == ""){
                // jika kosong, get data dari function getData() dan menghitung row
                totalMember = getData().Tables[0].Rows.Count;
            }else{
                // jika tidak kosong, get data dari function searchMember() dan menghitung row
                totalMember = searchMember().Tables[0].Rows.Count;
            }

            // return variabe totalMember
            return totalMember;
        }

        // check list peminjaman member
        public int checkPinjamBarang(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT id_member from peminjaman WHERE id_member='" + id + "' AND status='0'", "peminjaman");
            if (data.Tables[0].Rows.Count == 0){
                return 0;
            }else{
                return 1;
            }
        }
    }
}
