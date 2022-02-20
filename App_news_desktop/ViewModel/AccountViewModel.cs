using App_news_desktop.Model;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace App_news_desktop.ViewModel
{
    public static class RandomChar
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
    class AccountViewModel:BaseViewModel
    {             
        private ObservableCollection<Users> _List;
        public ObservableCollection<Users> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<Quyen> _Quyen;
        public ObservableCollection<Quyen> Quyen { get => _Quyen; set { _Quyen = value; OnPropertyChanged(); } }
        
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }

        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        private string _PasswordAgain;
        public string PasswordAgain { get => _PasswordAgain; set { _PasswordAgain = value; OnPropertyChanged(); } }

        private string _ViTri;
        public string ViTri { get => _ViTri; set { _ViTri = value; OnPropertyChanged(); } }

        private string _imgn;
        public string imgn { get => _imgn; set { _imgn = value; OnPropertyChanged(); } }

        private Quyen _SelectedQuyen;
        public Quyen SelectedQuyen
        {
            get => _SelectedQuyen;
            set
            {
                _SelectedQuyen = value;
                OnPropertyChanged();
            }
        }
        private Users _SelectedItem;
        public Users SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.DisplayName;
                    UserName = SelectedItem.UserName;
                    ViTri= SelectedItem.ViTri;
                    SelectedQuyen = SelectedItem.Quyen;
                    imgn = SelectedItem.imgn;
                }
            }
        }

        public ICommand LoadedWindowCommand { get; set; }
        public ICommand AddUserCommand { get; set; }
        public ICommand EditUserCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand PasswordAgainChangedCommand { get; set; }
        public ICommand AddImageCommand { get; set; }
        public ICommand AddAccountCommand { get; set; }
               
        public AccountViewModel()
        {   
            List = new ObservableCollection<Users>(DataProvider.Ins.DB.Users);
            Quyen = new ObservableCollection<Quyen>(DataProvider.Ins.DB.Quyen);
            AddUserCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DisplayName = null;
                UserName = null;
                ViTri = null;
                SelectedQuyen = null;
                Password = null;
                PasswordAgain = null;
            
                imgn = "C:\\Users\\cong\\Desktop\\btldd\\App_news_Androind\\App_news_Androind.Android\\Resources\\drawable\\image.jpg";
                AccountWindow wd = new AccountWindow(); 
                wd.ShowDialog();              
            });
            EditUserCommand = new RelayCommand<object>((p) => {
                if (SelectedItem == null) return false;
                else return true;
                }, (p) => {
                EditAccountWindow wd = new EditAccountWindow();
                wd.ShowDialog();
            });
            AddImageCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Select image";
                fileDialog.InitialDirectory = "";
                fileDialog.Filter = "Image Files (*.gif,*.jpg,*.jpeg,*.bmp,*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.png";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == true)
                {
                    imgn = fileDialog.FileName;
           
                }
            });
            AddCommand = new RelayCommand<object>((p) =>
            {
                
                if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ViTri) || SelectedQuyen == null )
                    return false;
                if (Password != PasswordAgain) return false;
                var userNamesame= DataProvider.Ins.DB.Users.Where(x => x.UserName == UserName);
                if (userNamesame == null || userNamesame.Count() != 0)
                    return false;
                
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
                var nUser = new Users() { DisplayName = DisplayName, UserName = UserName, Password = MD5Hash(Password), ViTri = ViTri, IdQuyen = SelectedQuyen.Id,imgn= newPathToFile };
                DataProvider.Ins.DB.Users.Add(nUser);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(nUser);
                MessageBox.Show("Đã thêm tài khoản thành công!");
            });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { Password = p.Password; });
            PasswordAgainChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { PasswordAgain = p.Password; });
            EditCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(DisplayName)  || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ViTri) || SelectedQuyen == null)
                    return false;
                if (Password != PasswordAgain) return false;
                return true;

            }, (p) =>
            {
                var cUser = DataProvider.Ins.DB.Users.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();
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
                cUser.ViTri = ViTri;
                cUser.IdQuyen = SelectedQuyen.Id;
                cUser.imgn = newPathToFile;
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Đã sửa tài khoản thành công!");
                SelectedItem.DisplayName = DisplayName;
            });
            AddAccountCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                    return false;
                if (Password != PasswordAgain) return false;
                var userNamesame = DataProvider.Ins.DB.Users.Where(x => x.UserName == UserName);
                if (userNamesame == null || userNamesame.Count() != 0)
                    return false;

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
                var nUser = new Users() { DisplayName = DisplayName, UserName = UserName, Password = MD5Hash(Password), ViTri = "Khách", IdQuyen = 3, imgn = newPathToFile };
                DataProvider.Ins.DB.Users.Add(nUser);
                DataProvider.Ins.DB.SaveChanges();

                List.Add(nUser);
                MessageBox.Show("Đã thêm tài khoản thành công!");
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
