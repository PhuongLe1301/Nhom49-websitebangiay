using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.Dao
{
    public class ProductDao
    {
        HPStoreDbContext db = null;
        public ProductDao()
        {
            db = new HPStoreDbContext();
        }
        public List<Product> ListNike(int top)
        {
            return db.Products.OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
        public List<Product> ListMLB(int top)
        {
            return db.Products.Where(x => x.TopHot != null && x.TopHot>DateTime.Now).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
        public List<Product> ListAdidas(int top)
        {
            return db.Products.Where(x => x.ModifiedDate != null && x.ModifiedDate > DateTime.Now).OrderByDescending(x => x.CreateDate).Take(top).ToList();
        }
        public List<Product> ListRelatedProducts(long productId)
        {
            var product = db.Products.Find(productId);
            return db.Products.Where(x => x.ID != productId && x.CategoryID == product.CategoryID).ToList();
        }
        public Product ViewDetail(long id)
        {
            return db.Products.Find(id);
        }
    }
}
