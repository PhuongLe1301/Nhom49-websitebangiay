using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class ContentDao
    {
        HPStoreDbContext db = null;
        public ContentDao()
        {
            db = new HPStoreDbContext();
        }
        public Content GetByID(long id)
        {
            return db.Contents.Find(id);
        }
    }
}
