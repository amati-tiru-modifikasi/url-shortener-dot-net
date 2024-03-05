using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ShortenedUrl"] = "This is just a short url";
            ViewData["AllUrls"] = new List<string>() { "url 1", "url 2", "url 3", "url 4"};
             
            return View();
        }
    }
}
