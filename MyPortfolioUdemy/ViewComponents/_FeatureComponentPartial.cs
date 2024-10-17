using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            /*burada sunu soylemis olduk myportfoliocontext içinde yer alan
             *features tablosundaki butun verileri listele dedık*/
            var values = portfolioContext.features.ToList();
            return View(values);
        }
    }
}
