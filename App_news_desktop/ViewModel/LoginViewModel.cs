using App_news_desktop.Model;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace App_news_desktop.ViewModel
{
    class LoginViewModel:BaseViewModel
    {
        public long Id { get; set; }
        public ICommand CloseWindowCommand { get; set; }
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        
        public ICommand PasswordChangedCommand { get; set; }
        public LoginViewModel()
        {
            Password = "";
            UserName = "";
            CloseWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                Login(p);
            });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
        }

        private void Login (Window p)
        {
            if (p == null)
                return;
            
            string passEncode = MD5Hash(Password);
            var acc = DataProvider.Ins.DB.Users.Where(x => x.UserName == UserName && x.Password == passEncode);
            int accCount = acc.Count();

            if (accCount > 0)
            {
                Id = acc.First().Id;
                Messenger.Default.Send(Id);
                p.Close();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }

        }

        private static string Base64Encode(string plainText)
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
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
