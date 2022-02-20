using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App_news_Androind.ViewModel
{
    class BaseViewModel
    {
        //Kich hoat su kien thong bao no co thay doi mot thuoc tinh nao do
        public event PropertyChangedEventHandler PropertyChanged;
        //Invoke() tranh xung dot luong
        //Thong bao co su thay doi
        //CallerMemberName thuc su khong biet thu se thay doi la gi
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
