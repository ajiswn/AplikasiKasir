using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKasir.Kelas
{
    internal class Users
    {
        int id;
        string username;
        string password;
        string role;
        protected const String conString = "server=localhost;database=db_penjualan_app;uid=root;pwd=;";

        public Users(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        //method getUser() akan melakukan query ke tabel users untuk mengecek
        //apakah objek user terdata di tabel users. Jika ada akan mengembalikan nilai boolean true;
        public bool getUser()
        {
            bool result = false;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @user && password = @pwd", connect);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pwd", password);
            cmd.CommandType = CommandType.Text;
            //cmd.Connection = connect;
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }
    }
}
