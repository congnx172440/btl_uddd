using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App_news_Androind.View;
using App_news_Androind.ViewModel;

namespace App_news_Androind
{
    public partial class MainPage : Shell
    {
        private string _Login;
        public string Login { get => _Login; set { _Login = value; OnPropertyChanged(); } }

        private string _Logout;
        public string Logout { get => _Logout; set { _Logout = value; OnPropertyChanged(); } }

        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }
        private string _imgn;
        public string imgn { get => _imgn; set { _imgn = value; OnPropertyChanged(); } }

        private string _ViTri;
        public string ViTri
        {
            get => _ViTri; set { _ViTri = value; OnPropertyChanged(); }
        }



        public MainPage()
        {
            InitializeComponent();
            PropertyChanged += Shell_PropertyChanged;
            BindingContext = this;          
        }


        private void Shell_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("FlyoutIsPresented"))
                if (FlyoutIsPresented)
                {
                    Login = TaiKhoanViewModel.Login;
                    Logout = TaiKhoanViewModel.Logout;
                    DisplayName = TaiKhoanViewModel.DisplayName;
                    imgn = TaiKhoanViewModel.imgn;
                    ViTri = TaiKhoanViewModel.ViTri;
                }   
                            
        }

    }

}
