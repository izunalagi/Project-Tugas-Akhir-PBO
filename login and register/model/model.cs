using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coba2.model
{
    internal class akun
    {
        public string username;
        public string password;
        public string no_telepon;
        public DateTime tgl_masuk;

        public void register()
        {
            NpgsqlConnection koneksi = new NpgsqlConnection("Host=localHost;Username=postgres;Password=alfi2265;Database=pbo tugas akhir");
            koneksi.Open();

            NpgsqlCommand perintah = new NpgsqlCommand($"insert into akun (username, password, no_telepon, tgl_masuk, id_role) values ('{this.username}','{this.password}','{this.no_telepon}','{tgl_masuk}','2')", koneksi);

            perintah.ExecuteNonQuery();
            koneksi.Close();
        }

        public bool login()
        {
            NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=alfi2265;Database=pbo tugas akhir");
            con.Open();

           
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT username, password FROM akun WHERE username = '{this.username}' AND password = '{this.password}'", con);
            
            NpgsqlDataReader reader = cmd.ExecuteReader();
            bool loginSuccessful = reader.HasRows;
            reader.Close();
            con.Close();

            return loginSuccessful;
        }
    }
}
