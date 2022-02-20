using App_news_Androind.Model;
using App_news_Androind.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App_news_Androind.ViewModel
{
    class TinTucViewModel : BaseViewModel
    {

        private List<TinTuc> _List;
        public List<TinTuc> List { get => _List; set { _List= value; OnPropertyChanged(); } }

        private static List<BinhLuan> _ListBinhLuan;
        public List<BinhLuan> ListBinhLuan { get => _ListBinhLuan; set { _ListBinhLuan = value; OnPropertyChanged(); } }

        private static long _IdTinTuc;
        public long IdTinTuc { get => _IdTinTuc; set { _IdTinTuc = value; OnPropertyChanged(); } }

        private static Users _Author;
        public Users Author { get => _Author; set { _Author = value; OnPropertyChanged(); } }
        
        private static string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }


        private static string _Content;
        public string Content { get => _Content; set { _Content = value; OnPropertyChanged(); } }

        private static string _imgn;
        public string imgn { get => _imgn; set { _imgn = value; OnPropertyChanged(); } }

        private static string _LinkCT;
        public string LinkCT { get => _LinkCT; set { _LinkCT = value; OnPropertyChanged(); } }

        private static string _NgayDang;
        public string NgayDang { get => _NgayDang; set { _NgayDang = value; OnPropertyChanged(); } }


        private static string _UserDisplayName;
        public string UserDisplayName { get => _UserDisplayName; set { _UserDisplayName = value; OnPropertyChanged(); } }

        private static string _imgnDisplayName;
        public string imgnDisplayName { get => _imgnDisplayName; set { _imgnDisplayName = value; OnPropertyChanged(); } }

        private static TinTuc _SelectedItem;
        public TinTuc SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    get_author();
                    get_binhluan();
                    IdTinTuc = SelectedItem.Id;
                    DisplayName = SelectedItem.DisplayName;
                    Content = SelectedItem.Content;
                    imgn = Path.GetFileName(SelectedItem.imgn);
                    LinkCT = SelectedItem.LinkCT;

                    Clicked();
                    

                }
            }
        }

        public Command GoBackCommand { get; set; }
        public TinTucViewModel()
        {
            GoBackCommand = new Command(async () => await GoBack());
        }
        private async Task GoBack()
        {
             await Shell.Current.GoToAsync("..", true);
            
        }
        async private void Clicked()
        {
           
            await Shell.Current.GoToAsync("detailnews");

        }
        private async void get_author()
        {
            Author = await App.db.UserGetId(SelectedItem.IdUser);
        }
        private async void get_binhluan()
        {
            ListBinhLuan = await App.db.BinhLuanList(SelectedItem.Id);
        }

    }
}