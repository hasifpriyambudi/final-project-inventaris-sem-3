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
        public string id_admin { get; set; }

        public modelMember(){
            temp = new Koneksi();
        }

        public bool prosesTambah(){
            string data = "'" + nama+ "','" + email+"','"+nomor+"','"+alamat+"','"+id_admin+"'";
            return temp.Insert("member", data);
        }

        public DataSet getData(){
            DataSet data = new DataSet();
            data = temp.SelectData("SELECT a.*, b.nama_admin FROM member a JOIN admin b ON a.id_admin=b.id_admin", "admin");
            return data;
        }
    }
}
