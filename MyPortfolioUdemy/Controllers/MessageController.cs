﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class MessageController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var values=context.Messages.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadToTrue(int id)//true olurken bu kod calısacak
		{
			var value=context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
		public IActionResult ChangeIsReadToFalse(int id)//false olurken bu kod calısacak
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}
	}
}