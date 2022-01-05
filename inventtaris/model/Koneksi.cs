using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace inventtaris.model{
    class Koneksi{
        private static SqlConnection conn;
        private SqlCommand command;
        private bool result;
        
        // Koneksi ke database
        public static SqlConnection GetConnection(){
            //instance
            conn = new SqlConnection();
            //set connection
            conn.ConnectionString = "Data Source = DESKTOP-14NT0UB;" +
                                    "Initial Catalog = inventaris;" +
                                    "Integrated Security = True";
            return conn;
        }

        public Koneksi(){
            GetConnection();
        }

        // Template Select
        public DataSet Select(string tabel, string kondisi){
            DataSet data = new DataSet();
            try{
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                if (kondisi == null){
                    command.CommandText = "SELECT * FROM " + tabel;
                }else{
                    command.CommandText = "Select * FROM " + tabel + " WHERE " + kondisi;
                }
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(data, tabel);
            }catch (SqlException){
                data = null;
            }
            conn.Close();
            return data;
        }

        // Template Select (Counting, Top, Grouping)
        public DataSet SelectData(string query, string tabel){
            DataSet data = new DataSet();
            try{
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(data, tabel);
            }catch (SqlException){
                data = null;
            }
            conn.Close();
            return data;
        }

        // insert data
        public Boolean Insert(string tabel, string data){
            result = false;
            try{
                string query = "INSERT INTO " + tabel + " VALUES (" + data + ")";
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }catch (SqlException) {
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Update(string tabel, string data, string kondisi){
            result = false;
            try{
                string query = "UPDATE " + tabel + " SET " + data + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }catch (SqlException){
                result = false;
            }
            conn.Close();
            return result;
        }

        public Boolean Delete(string tabel, string kondisi){
            result = false;
            try{
                string query = "DELETE FROM " + tabel + " WHERE " + kondisi;
                conn.Open();
                command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = query;
                command.ExecuteNonQuery();
                result = true;
            }catch (SqlException){
                result = false;
            }
            conn.Close();
            return result;
        }

        //public int countData(string tabel, string kondisi){
        //    result = false;
        //}
    }
}
