using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_news_Androind
{
    public interface ISQLite
    {
        SQLiteAsyncConnection GetConnection();
    }
}
