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
    public partial class TinTucHoatDong : ContentPage
    {
        public TinTucHoatDong()
        {
            InitializeComponent();
        }
        async protected override void OnAppearing()
        {
            List2.ItemsSource = await App.db.TinTucListCD(2);
        }

        
    }
}