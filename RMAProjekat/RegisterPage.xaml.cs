﻿using RMAProjekat.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RMAProjekat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtRegisterPassword1.Text == txtRegisterPassword2.Text)
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<RegUserTable>();
                var item = new RegUserTable()
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    UserName = txtUserName.Text,
                    Password1 = txtRegisterPassword1.Text,
                    Password2 = txtRegisterPassword2.Text
                };
                db.Insert(item);
                Device.BeginInvokeOnMainThread(async () =>
                {
                    DisplayAlert("Uspjesna registracija", "Uspjesno ste se registrovali", "Ok");
                    Navigation.PushAsync(new LoginPage());
                });
            }
            else
            {
                DisplayAlert("Neuspjesna registracija", "Sifre se ne podudaraju", "Ok");
            }
        }
    }
}