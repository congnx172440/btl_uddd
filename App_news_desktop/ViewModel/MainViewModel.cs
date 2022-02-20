using App_news_desktop.Model;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace App_news_desktop.ViewModel
{
    public class MyUser
    {
        public static long Id { get; set; }
    }
    public class MainViewModel : BaseViewModel
    {
        

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _DisplayLogin;
        public string DisplayLogin { get => _DisplayLogin; set { _DisplayLogin = value; OnPropertyChanged(); } }

        private string _DisplayLogout;
        public string DisplayLogout { get => _DisplayLogout; set { _DisplayLogout = value; OnPropertyChanged(); } }

        private string _DisplayTinTuc;
        public string DisplayTinTuc { get => _DisplayTinTuc; set { _DisplayTinTuc = value; OnPropertyChanged(); } }

        private string _DisplayTaiKhoan;
        public string DisplayTaiKhoan { get => _DisplayTaiKhoan; set { _DisplayTaiKhoan = value; OnPropertyChanged(); } }

        private string _DisplayCaiDat;
        public string DisplayCaiDat { get => _DisplayCaiDat; set { _DisplayCaiDat = value; OnPropertyChanged(); } }

        private string _DisplayDangKy;
        public string DisplayDangKy { get => _DisplayDangKy; set { _DisplayDangKy = value; OnPropertyChanged(); } }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand AddAccountCommand { get; set; }
        public ICommand EditAccountCommand { get; set; }

        public MainViewModel()
        {
            MyUser.Id = 0;
            if (MyUser.Id == 0)
            {
                DisplayName = "Khách";
                DisplayLogin = "Visible";
                DisplayLogout = "Collapsed";
                DisplayTinTuc = "Collapsed";
                DisplayTaiKhoan = "Collapsed";
                DisplayCaiDat = "Collapsed";
                DisplayDangKy = "Visible";
            }
           
            Messenger.Default.Register<long>(this, (Id) =>
            {
                MyUser.Id = Id;
                change();
            });
            LoginCommand = new RelayCommand<object>((p) => { return true; }, (p) => { LoginWindow wd = new LoginWindow(); wd.ShowDialog(); });
            AddAccountCommand= new RelayCommand<object>((p) => { return true; }, (p) => { AddAccount wd = new AddAccount(); wd.ShowDialog(); });
            EditAccountCommand = new RelayCommand<object>((p) => { return true; }, (p) => { MyAccount wd = new MyAccount(); wd.ShowDialog(); });
            LogoutCommand = new RelayCommand<object>((p) => { return true; }, (p) => 
            {
                MyUser.Id = 0;
                DisplayName = "Khách";
                DisplayLogin = "Visible";
                DisplayLogout = "Collapsed";
                DisplayTinTuc = "Collapsed";
                DisplayTaiKhoan = "Collapsed";
                DisplayCaiDat = "Collapsed";
                DisplayDangKy = "Visible";
            });

        }
        void change()
        {
            var acc = DataProvider.Ins.DB.Users.Where(x => x.Id == MyUser.Id).First();
            if (acc.IdQuyen == 1)
            {
                DisplayName = acc.UserName.ToString();
                DisplayLogin = "Collapsed";
                DisplayLogout = "Visible";
                DisplayTinTuc = "Visible";
                DisplayTaiKhoan = "Visible";
                DisplayCaiDat = "Visible";
                DisplayDangKy = "Collapsed";
            }
            else if (acc.IdQuyen == 2)
            {
                DisplayName = acc.UserName.ToString();
                DisplayLogin = "Collapsed";
                DisplayLogout = "Visible";
                DisplayTinTuc = "Visible";
                DisplayTaiKhoan = "Collapsed";
                DisplayCaiDat = "Visible";
                DisplayDangKy = "Collapsed";
            }
            else if (acc.IdQuyen == 3)
            {
                DisplayName = acc.UserName.ToString();
                DisplayLogin = "Collapsed";
                DisplayLogout = "Visible";
                DisplayTinTuc = "Collapsed";
                DisplayTaiKhoan = "Collapsed";
                DisplayCaiDat = "Visible";
                DisplayDangKy = "Collapsed";
            }
            
        }
       
    }
}
