using System;
using System.Collections.Generic;
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
            if(txtRegisterPassword1.Text == txtRegisterPassword2.Text)
            {
                DisplayAlert("Uspjesna registracija", "Uspjesno ste se registrovali", "Ok");
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Neispravan unos", "Sifre se ne podudaraju", "Ok");
            }
        }
    }
}