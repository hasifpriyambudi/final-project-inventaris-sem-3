using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows;

namespace inventtaris.controller{
    class C_cekLogin{
        model.cekLogin cekLogin;
        view.login viewLogin;

        public C_cekLogin(view.login viewLogin){
            cekLogin = new model.cekLogin();
            this.viewLogin = viewLogin;
        }

        public void login(){
            cekLogin.userAdmin = viewLogin.txtUsername.Text;
            cekLogin.password = viewLogin.txtPassword.Password;
            bool result = cekLogin.cek();
            if (result){
                view.Dash dash = new view.Dash();
                dash.Show();
                viewLogin.Close();
            }else {
                MessageBox.Show("Maaf, Username/Password Salah!");
                viewLogin.txtUsername.Text = "";
                viewLogin.txtPassword.Password = "";
                viewLogin.txtUsername.Focus();
            }
        }
    }
}
