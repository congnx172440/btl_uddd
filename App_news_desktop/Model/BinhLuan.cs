//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_news_desktop.Model
{
    using App_news_desktop.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class BinhLuan:BaseViewModel
    {
        private long _Id { get; set; }
        public long Id { get => _Id; set { _Id = value; OnPropertyChanged(); } }
        private string _Content { get; set; }
        public string Content { get => _Content; set { _Content = value; OnPropertyChanged(); } }
        private long _IdUser { get; set; }
        public long IdUser { get => _IdUser; set { _IdUser = value; OnPropertyChanged(); } }
        private long _IdTinTuc { get; set; }
        public long IdTinTuc { get => _IdTinTuc; set { _IdTinTuc = value; OnPropertyChanged(); } }

        public virtual TinTuc TinTuc { get; set; }
        public virtual Users Users { get; set; }
    }
}
