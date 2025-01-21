using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.ToDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();//okunmamaış yada tamamlanmamış verilerin sayısını verir
			var values = context.ToDoLists.Where(x => x.Status == false).ToList();
			return View(values);
		}
    }
}
