using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.RentACarFilterComponents
{
    public class _RentACarListFilterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke(string v)
        {
            v = "aaa";
            TempData["value"] = v;
            return View();
        }
    }
}
