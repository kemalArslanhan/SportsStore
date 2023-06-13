using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repo;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            this.repo = repo;
        }

      
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repo.Products
                        .Select(p => p.Category)
                        .Distinct()
                        .OrderBy(c => c));
        }
    }
}
