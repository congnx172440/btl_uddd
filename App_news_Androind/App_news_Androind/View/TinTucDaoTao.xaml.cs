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
    public partial class TinTucDaoTao : ContentPage
    {
        public TinTucDaoTao()
        {
            InitializeComponent();
        }

        async protected override void OnAppearing()
        {
            List1.ItemsSource= await App.db.TinTucListCD(1);
        }
    }

}