using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }

        /*sayfa ilk yuklendıgı zaman burası karsılama yapacaktır*/
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        /*sayfa ilk yuklendıgı zaman butun ıslemlerı gorecek alan burasıdır yanı tıklama ıslemlerı olacaktır
         her iki metodta aynı olmasın diye tıklama yapılacak olan metoda gerı donus degerlı olması lazım*/
		[HttpPost]
		public IActionResult CreateExperience(Experience experience)//ekstradan view eklemeyi unutma
		{
            context.Experiences.Add(experience);//parametreden gelen degeri ekler
            context.SaveChanges();//eklenen degeri veri tabanında kayıt eder
			return RedirectToAction("ExperienceList");//yapılan ıslemlerı en basta listeleme yapmayı saglar
		}

        /*silme islemi yapıyoruz*/
        public IActionResult DeleteExperience(int id)//geriye deger donduren parametreli metod
        {
            var value = context.Experiences.Find(id);//degeri bulup degıskene atar
            context.Experiences.Remove(value);//degiskene atılan degerı siler
            context.SaveChanges();//veri tabanına kayıt yapar
            return RedirectToAction("ExperienceList");//yapılan ıslerı burada gosterdık
        }

        [HttpGet]//istek karsılandı
        public IActionResult UpdateExperience(int id)//parametre verildi ve donus saglandı
        {
            var value=context.Experiences.Find(id);//verilen deger alındı
            return View(value);//geri gostermek ıcın basıldı
        }

        [HttpPost]//karsılanan ıstege karsı cevap verildi
        public IActionResult UpdateExperience(Experience experience)//deger atanıp geri istenir
        {
            context.Experiences.Update(experience);//verilen deger update edılıyor
            context.SaveChanges();//verı tabanına kayıt yapıldı
			return RedirectToAction("ExperienceList");//gosterılecek yer verıldı
		}
	}
}
