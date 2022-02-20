using App_news_Androind.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_news_Androind.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroductPage : ContentPage
    {
        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _ViTri;
        public string ViTri
        {
            get => _ViTri; set { _ViTri = value; OnPropertyChanged(); }
        }
        public IntroductPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DisplayName = TaiKhoanViewModel.DisplayName;
            ViTri = TaiKhoanViewModel.ViTri;
        }
    }
}