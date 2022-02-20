using App_news_Androind.Data;
using App_news_Androind.View;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace App_news_Androind
{
    public partial class App : Application
    {
        public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
        private static QuanLyTinTucDB _db;
        public static QuanLyTinTucDB db
        {
            get
            {
                if (_db == null)
                 _db = new QuanLyTinTucDB(); 
                return _db;
            }
        }
        public App()
        {
            InitializeComponent();
            RegisterRoutes();
            MainPage = new MainPage();
        }
        void RegisterRoutes()
        {
            Routes.Add("trangchu", typeof(IntroductPage));
            Routes.Add("login", typeof(LoginPage));
            Routes.Add("tintucdaotao", typeof(TinTucDaoTao));
            Routes.Add("tintuchoatdong", typeof(TinTucHoatDong));
            Routes.Add("tintucnghiencuu", typeof(TinTucNghienCuu));
            Routes.Add("tintuctuyendung", typeof(TinTucTuyenDung));
            Routes.Add("tintuctuyensinh", typeof(TinTucTuyenSinh));
            Routes.Add("dangky", typeof(DangKy));
            Routing.RegisterRoute("detailnews", typeof(ChiTietTinTuc));


            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
