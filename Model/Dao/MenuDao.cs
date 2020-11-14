using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class MenuDao
    {
        HPStoreDbContext db = null;
        public MenuDao()
        {
            db = new HPStoreDbContext();
        }

        public List<Menu> ListByGroudId(int groupID)
        {
            return db.Menus.Where(x => x.TypeID == groupID && x.Status==true).OrderBy(x=>x.DisplayOrder).ToList();
        }
    }
}
