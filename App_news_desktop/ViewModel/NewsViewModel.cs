using App_news_desktop.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;


namespace App_news_desktop.ViewModel
{
    
    class NewsViewModel:BaseViewModel
    {
        private ObservableCollection<TinTuc> _List;
        public ObservableCollection<TinTuc> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<Users> _User;
        public ObservableCollection<Users> User { get => _User; set { _User = value; OnPropertyChanged(); } }
        
        private ObservableCollection<LoaiTin> _LoaiTin;
        public ObservableCollection<LoaiTin> LoaiTin { get => _LoaiTin; set { _LoaiTin = value; OnPropertyChanged(); } }


        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _Content;
        public string Content { get => _Content; set { _Content = value; OnPropertyChanged(); } }

        private string _imgn;
        public string imgn { get => _imgn; set { _imgn = value; OnPropertyChanged(); } }

        private string _LinkCT;
        public string LinkCT { get => _LinkCT; set { _LinkCT = value; OnPropertyChanged(); } }

        private string _NgayDang;
        public string NgayDang { get => _NgayDang; set { _NgayDang = value; OnPropertyChanged(); } }

        
        private LoaiTin _SelectedLoaiTin;
        public LoaiTin SelectedLoaiTin
        {
            get => _SelectedLoaiTin;
            set
            {
                _SelectedLoaiTin = value;
                OnPropertyChanged();
            }
        }

        private Users _SelectedUser;
        public Users SelectedUser
        {
            get => _SelectedUser;
            set
            {
                _SelectedUser = value;
                OnPropertyChanged();
            }
        }

        private TinTuc _SelectedItem;
        public TinTuc SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    DisplayName = SelectedItem.DisplayName;
                    Content = SelectedItem.Content;
                    LinkCT = SelectedItem.LinkCT;
                    imgn = SelectedItem.imgn;
                    NgayDang = SelectedItem.NgayDang;
                    SelectedUser = SelectedItem.Users;
                    SelectedLoaiTin = SelectedItem.LoaiTin;
                }
            }
        }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand AddNewsCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditNewsCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand AddImageCommand { get; set; }
        public NewsViewModel()
        {           
            List = new ObservableCollection<TinTuc>(new List<TinTuc>(DataProvider.Ins.DB.TinTuc.OrderByDescending(x => x.Id)));
            User = new ObservableCollection<Users>(new List<Users>(DataProvider.Ins.DB.Users));
            LoaiTin = new ObservableCollection<LoaiTin>(new List<LoaiTin>(DataProvider.Ins.DB.LoaiTin));           
            AddNewsCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                DisplayName = null;
                Content = null;
                LinkCT = null;
                SelectedUser = null;
                SelectedLoaiTin = null;
            
                imgn = "C:\\Users\\cong\\Desktop\\btldd\\App_news_Androind\\App_news_Androind.Android\\Resources\\drawable\\image.jpg";
                NewsWindow wd = new NewsWindow();
                wd.ShowDialog();
            });
            EditNewsCommand = new RelayCommand<object>((p) => {
                if (SelectedItem == null) return false;
                else return true;
            }, (p) => {
                EditNewsWindow wd = new EditNewsWindow();
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

                if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Content) || SelectedLoaiTin == null)
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
                    string newDir = "C:\\Users\\cong\\Desktop\\btldd\\App_news_Androind\\App_news_Androind.Android\\Resources\\drawable\\drawable\\";
                    string curFile = string.Concat(Path.GetFileNameWithoutExtension(imgn), RandomChar.RandomString(10), Path.GetExtension(imgn));
                    newPathToFile = Path.Combine(newDir, curFile);
                    File.Copy(imgn, newPathToFile);
                }
                var nTinTuc = new TinTuc() { DisplayName = DisplayName, Content = Content, LinkCT = LinkCT, IdLoaiTin = SelectedLoaiTin.Id, imgn = newPathToFile,
                    IdUser = MyUser.Id, NgayDang = DateTime.Now.ToString("HH:mm dd/MM/yyyy ")
                };
                DataProvider.Ins.DB.TinTuc.Add(nTinTuc);
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Đã thêm bài viết thành công!");
                List.Add(nTinTuc);
            });
            EditCommand = new RelayCommand<object>((p) =>
            {

                if (string.IsNullOrEmpty(DisplayName) || string.IsNullOrEmpty(Content) || SelectedLoaiTin == null)
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

                var nTinTuc = DataProvider.Ins.DB.TinTuc.Where(x => x.Id == SelectedItem.Id).SingleOrDefault();

                nTinTuc.DisplayName = DisplayName;
                nTinTuc.Content = Content;
                nTinTuc.LinkCT = LinkCT;
                nTinTuc.IdLoaiTin = SelectedLoaiTin.Id;
                nTinTuc.imgn = newPathToFile;
                nTinTuc.NgayDang = DateTime.Now.ToString("HH:mm dd/MM/yyyy ");              
                DataProvider.Ins.DB.SaveChanges();
                MessageBox.Show("Đã sửa bài viết thành công!");
                SelectedItem.DisplayName = DisplayName;
            });
        }
    }
}
