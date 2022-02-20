using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using App_news_Androind;
using App_news_Androind.Model;
using SQLite;

namespace App_news_Androind.Data
{
    public class QuanLyTinTucDB
    {
        static SQLiteAsyncConnection csdl;
        public QuanLyTinTucDB()
        {
            string DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "btldd3.db");

            Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            Stream embeddeDatabaseStream = assembly.GetManifestResourceStream("App_news_Androind.btldd3.db");
            if(File.Exists(DatabasePath))
            {
                FileStream fileStreamToWrite = File.Create(DatabasePath);
                embeddeDatabaseStream.Seek(0, SeekOrigin.Begin);
                embeddeDatabaseStream.CopyTo(fileStreamToWrite);
                fileStreamToWrite.Close();
            }
            csdl = new SQLiteAsyncConnection(DatabasePath);
            csdl.CreateTableAsync<LoaiTin>().Wait();
        }
        public Task<Quyen> QuyenId(long Id)
        {
            return csdl.Table<Quyen>().Where(u => u.Id == Id).FirstOrDefaultAsync();
        }
        public Task<Users> UserGetId(long Id)
        {
            return csdl.Table<Users>().Where(u => u.Id == Id).FirstOrDefaultAsync();
        }
        public Task<LoaiTin> LoaiTinId(long Id)
        {
            return csdl.Table<LoaiTin>().Where(u => u.Id == Id).FirstOrDefaultAsync();
        }
        public Task<TinTuc> TinTucId(long Id)
        {
            return csdl.Table<TinTuc>().Where(u => u.Id == Id).FirstOrDefaultAsync();
        }
        public Task<Users> UserGetLogin(string Username,string Password)
        {
            return csdl.Table<Users>().Where(u =>  u.UserName == Username && u.Password == Password).FirstOrDefaultAsync();
        }
        public Task<List<TinTuc>> TinTucList()
        {
            Task<List<TinTuc>> listt = csdl.Table<TinTuc>().ToListAsync();
            return listt;
        }
        public Task<List<TinTuc>> TinTucListCD(long Id)
        {
            
            return csdl.Table<TinTuc>().Where(u => u.IdLoaiTin == Id).ToListAsync();
        }
        public Task<List<BinhLuan>> BinhLuanList(long Id)
        {
            return csdl.Table<BinhLuan>().Where(u => u.IdTinTuc == Id).ToListAsync();
        }
    }
}
