﻿using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKasir.Kelas
{
    internal class Barangs
    {
        protected const String conString = "server=localhost;database=db_penjualan_app;uid=root;pwd=;";
        string kode;
        string nama;
        int harga;
        int stok;
        string satuan;

        public Barangs(string kode, string nama, int harga, int stok, string satuan)
        {
            this.kode = kode;
            this.nama = nama;
            this.harga = harga;
            this.stok = stok;
            this.satuan = satuan;
        }
        public int insert()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO barangs (kode,nama,harga,stok,satuan) VALUES(@kode,@nama,@harga,@stok,@satuan)");
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@satuan", satuan);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
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
        public static DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            //cara 1
            MySqlConnection connect = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM barangs", connect))
            {
                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);

                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;
        }

        public static DataTable search(String txtSearch)
        {
            DataTable dt = new DataTable();
            //cara 1
            MySqlConnection connect = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM barangs WHERE kode LIKE '%" + txtSearch + "%' OR nama LIKE '%" + txtSearch + "%' ", connect))
            {
                try
                {
                    connect.Open();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);

                }
                catch (Exception e)
                {
                    String error = e.Message;
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
            return dt;
        }

        public int delete(string kode)
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM barangs WHERE kode=@kode", connect);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
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

        public int update()
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("UPDATE barangs SET nama=@nama, harga=@harga, stok=@stok, satuan=@satuan WHERE kode=@kode", connect);
            cmd.Parameters.AddWithValue("@kode", kode);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@satuan", satuan);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
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
