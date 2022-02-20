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
    public partial class TinTucTuyenSinh : ContentPage
    {
        public TinTucTuyenSinh()
        {
            InitializeComponent();
        }
        async protected override void OnAppearing()
        {
            List5.ItemsSource = await App.db.TinTucListCD(5);
        }
    }
}