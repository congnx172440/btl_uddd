using App_news_desktop.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
namespace App_news_desktop.ViewModel
{
    
    class MainNewsViewModel:BaseViewModel
    {
        
        private ObservableCollection<BinhLuan> _LBinhLuan;
        public ObservableCollection<BinhLuan> LBinhLuan { get => _LBinhLuan; set { _LBinhLuan = value; OnPropertyChanged(); } }
        private ObservableCollection<Users> _User;
        public ObservableCollection<Users> User { get => _User; set { _User = value; OnPropertyChanged(); } }
        public ObservableCollection<TinTuc> _List;
        public ObservableCollection<TinTuc> List { get => _List; set { _List = value; OnPropertyChanged(); } }
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand DaoTaoCommand { get; set; }
        public ICommand HoatDongCommand { get; set; }
        public ICommand NghienCuuCommand { get; set; }
        public ICommand TuyenSinhCommand { get; set; }
        public ICommand TuyenDungCommand { get; set;}
        public ICommand DocTinTucCommand { get; set;}
        public ICommand ThemBinhLuanCommand { get; set;}


        private string _DisplayName;
        public string DisplayName { get => _DisplayName; set { _DisplayName = value; OnPropertyChanged(); } }

        private string _DisplayIcon;
        public string DisplayIcon { get => _DisplayIcon; set { _DisplayIcon = value; OnPropertyChanged(); } }

        private string _Content;
        public string Content { get => _Content; set { _Content = value; OnPropertyChanged(); } }

        private string _imgn;
        public string imgn { get => _imgn; set { _imgn = value; OnPropertyChanged(); } }

        private string _LinkCT;
        public string LinkCT { get => _LinkCT; set { _LinkCT = value; OnPropertyChanged(); } }

        private string _NgayDang;
        public string NgayDang { get => _NgayDang; set { _NgayDang = value; OnPropertyChanged(); } }
        
        private string _Comment;
        public string Comment { get => _Comment; set { _Comment = value; OnPropertyChanged(); } }

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
                    {
                        switch (SelectedLoaiTin.Id)
                        {
                            case 1:
                                DisplayIcon= "BookEducationOutline";
                                break;
                            case 2:
                                DisplayIcon = "NaturePeople";
                                break;
                            case 3:
                                DisplayIcon = "AccountSearchOutline";
                                break;
                            case 4:
                                DisplayIcon = "Domain";
                                break;
                            case 5:
                                DisplayIcon = "School";
                                break;
                        }
                    }
                }
            }
        }
        public MainNewsViewModel()
        {
            DaoTaoCommand = new RelayCommand<object>((p) => { return true; }, (p) => { change(1); SelectedItem = null; });
            HoatDongCommand = new RelayCommand<object>((p) => { return true; }, (p) => { change(2); SelectedItem = null; });
            NghienCuuCommand = new RelayCommand<object>((p) => { return true; }, (p) => { change(3); SelectedItem = null; });            
            TuyenDungCommand = new RelayCommand<object>((p) => { return true; }, (p) => { change(4); SelectedItem = null; });
            TuyenSinhCommand = new RelayCommand<object>((p) => { return true; }, (p) => { change(5); SelectedItem = null; });
            DocTinTucCommand = new RelayCommand<object>((p) => {
                if(SelectedItem == null) return false;
                return true; }, (p) => {
                DetailNews wd = new DetailNews();
                User = new ObservableCollection<Users>(new List<Users>(DataProvider.Ins.DB.Users));
                LBinhLuan = new ObservableCollection<BinhLuan>(new List<BinhLuan>(DataProvider.Ins.DB.BinhLuan.Where(x=>x.IdTinTuc==SelectedItem.Id)));
                wd.ShowDialog();
            });
            void change(long i)
            {
                List = new ObservableCollection<TinTuc>(new List<TinTuc>(DataProvider.Ins.DB.TinTuc.OrderByDescending(x => x.Id).Where(x => x.IdLoaiTin == i)));
            }
            ThemBinhLuanCommand= new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Comment) || MyUser.Id ==0) return false;
                return true; }, 
                (p) => {
                    var nBinhLuan = new BinhLuan()
                    {
                        Content = Comment,
                        IdUser = MyUser.Id,
                        IdTinTuc = SelectedItem.Id,
                    };
                    DataProvider.Ins.DB.BinhLuan.Add(nBinhLuan);
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Đã thêm bình luận thành công!");
                    LBinhLuan.Add(nBinhLuan);
                    Comment = null;
                });
        }
        
    }
}
