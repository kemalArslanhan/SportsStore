using System.Linq;

namespace SportsStore.Models
{
    public class EFStoreRepository:IStoreRepository
    {
        private StoreDbContex ctx;
        public EFStoreRepository(StoreDbContex ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Product> Products =>ctx.Products;
    }
}
