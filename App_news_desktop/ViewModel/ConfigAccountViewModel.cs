using App_news_desktop.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace App_news_desktop.ViewModel
{
    class ConfigAccountViewModel:BaseViewModel
    {
        private long IdUser;
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }

        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        private string _PasswordAgain;
        public string PasswordAgain { get => _PasswordAgain; set { _PasswordAgain = value; OnPropertyChanged(); } }

        private string _imgn;
        public string imgn { get => _imgn; set { _imgn = value; OnPropertyChanged(); } }

        public ICommand EditAccountCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand PasswordAgainChangedCommand { get; set; }

        public ConfigAccountViewModel()
        {
            IdUser = MyUser.Id;
            var cUser = DataProvider.Ins.DB.Users.Where(x => x.Id == IdUser).SingleOrDefault();
            DisplayName = cUser.DisplayName;
            UserName = cUser.UserName;
            imgn = cUser.imgn;
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
            PasswordAgainChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { PasswordAgain = p.Password; });
            EditAccountCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Password))
                    return false;
                if (Password != PasswordAgain) return false;
                return true;

            }, (p) =>
            {
                string newPathToFile = "";
                if (imgn == "C:\\Users\\cong\\Desktop\\btldd\\App_news_Androind\\App_news_Androind.Android\\Resources\\drawable\\image.jpg")
                {
                    newPathToFile = imgn;
                }

                else
                {
                    string newDir = "C:\\Users\\cong\\Desktop\\btldd\\App_news_Androind\\App_news_Androind.Android\\Resources\\drawable\\";
                    string curFile = string.Concat(Path.GetFileNameWithoutExtension(imgn), RandomChar.RandomString(10), Path.GetExtension(imgn));
                    newPathToFile = Path.Combine(newDir, curFile);
                    File.Copy(imgn, newPathToFile);
                }
                cUser.DisplayName = DisplayName;
                cUser.Password = MD5Hash(Password);
                cUser.imgn = newPathToFile;
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Đã sửa tài khoản thành công!");
            });
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
