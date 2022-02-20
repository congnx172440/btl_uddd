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
    public partial class TinTucTuyenDung : ContentPage
    {
        public TinTucTuyenDung()
        {
            InitializeComponent();
        }
        async protected override void OnAppearing()
        {
            List4.ItemsSource = await App.db.TinTucListCD(1);
        }
    }
}