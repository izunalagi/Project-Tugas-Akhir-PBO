using coba2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace login_and_register.kontoller
{
    internal class register_controller
    {
        public void register(string username, string password, string no_telepon, DateTime tgl_masuk)
        {
            akun new_akun = new akun();
            new_akun.username = username;
            new_akun.password = password;
            new_akun.no_telepon = no_telepon;
            new_akun.tgl_masuk = tgl_masuk;
            new_akun.register();
        }

        public bool login(string user, string pass)
        {
            akun akun = new akun();
            akun.username = user;
            akun.password = pass;
            return akun.login();
        }

    }
}
