using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SportsStore.Models
{
    public class EFOrderRepository:IOrderRepository
    {
        public StoreDbContex ctx;
        public EFOrderRepository(StoreDbContex ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<Order> Orders =>ctx.Orders
                                .Include(o=> o.Lines)
                                .ThenInclude(l=>l.Product);
        public void SaveOrder(Order order)
        {
            ctx.AttachRange(order.Lines.Select(l=>l.Product));
            if (order.OrderID == 0)
            {
                ctx.Orders.Add(order);

            }
            ctx.SaveChanges();
        }

    }
}
 