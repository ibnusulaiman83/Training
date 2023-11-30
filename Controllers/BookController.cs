using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Training.Controllers
{
	public class BookController : Controller
	{
		//public String Index() 
		//{
		//	return "Ini adalah default saya ";
		//}

		public IActionResult Index() { 
			return View(); 		
		}

		public string Welcome(string name, int numtimes)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numtimes}");
		}

		public IActionResult About()
		{
			return View();
		}
	}
}
