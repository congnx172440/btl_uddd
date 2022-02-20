using App_news_Androind.Model;
using App_news_Androind.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_news_Androind.ViewModel
{
    class TaiKhoanViewModel:BaseViewModel
    {
        public static long IdUser;

        public static string DisplayName;


        public static string Login;


        public static string Logout;
     

        public static string imgn;

        public static string ViTri;

        private string _UserName;

        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;

        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        private static Users _Usern { get; set; }
        public Users Usern { get => _Usern; set { _Usern = value; OnPropertyChanged(); } }
        public Command SubmitCommand { set; get; }

        public TaiKhoanViewModel()
        {
            IdUser = 0;
            DisplayName = "Khách";
            imgn = "image.jpg";
            ViTri = "";
            Login = "True";
            Logout = "False";
            SubmitCommand = new Command(() =>login());
                        
        }
        async void  login()
        {
            Password = MD5Hash(Password);
            Usern = await App.db.UserGetLogin(UserName, Password);
            if (Login == "True")
            { 
                if (Usern == null)
                {
                    await App.Current.MainPage.DisplayAlert("Cảnh báo", "Sai tài khoản hoặc mật khẩu", "OK");
                }
                else
                {
                    DisplayName = Usern.DisplayName;
                    imgn = Path.GetFileName(Usern.imgn);
                    

                    ViTri = Usern.ViTri;
                    Login = "False";
                    Logout = "True";
                    await Shell.Current.GoToAsync("//tintucdaotao");
                }
            }
            else 
            {
                IdUser = 0;
                DisplayName = "Khách";
                imgn = "image.jpg";
                ViTri = "";
                Login = "True";
                Logout = "False";
            }    
        }
        private static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
