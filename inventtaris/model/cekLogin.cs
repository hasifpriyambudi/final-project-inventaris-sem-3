using System;
using System.Data;
using System.Windows;

namespace inventtaris.model{
    class cekLogin{
        Koneksi temp;
        public string id { get; set; }
        public string nama { get; set; }
        public string email{ get; set; }
        public string userAdmin { get; set; }
        public string password { get; set; }

        public static string idAdmin;
        public static string namaAdmin;

        public cekLogin(){
            temp = new Koneksi();
        }

        public Boolean cek(){
            bool result;
            DataSet data = new DataSet();
            data = temp.Select("admin", "user_admin = '" + userAdmin + "' AND password= '" + password + "' AND status_admin='1'");
            if(data.Tables[0].Rows.Count > 0){
                result = true;
                idAdmin = data.Tables[0].Rows[0][0].ToString();
                namaAdmin = data.Tables[0].Rows[0][1].ToString();
            }else{
                result = false;
            }
            return result;
        }
    }
}
