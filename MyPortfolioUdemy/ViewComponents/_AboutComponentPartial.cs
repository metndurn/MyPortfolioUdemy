using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            ViewBag.aboutTitle=portfolioContext.Abouts.Select(x => x.Title).ToList().FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).ToList().FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Detail).ToList().FirstOrDefault();
            return View(); 
        }
    }
}
