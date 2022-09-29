using Microsoft.AspNetCore.Mvc;

namespace Organizer.Controllers
{
	public class RecordsController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
	}
}