using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebDataProcessor.WebAPI.Controllers
{
    [ApiController, Route("~/")]
    public class AppController: ControllerBase
    {
        public ActionResult Index()
        {
            var startTime = DateTime.Now;
            //TODO: implement scraping and parsing here
            var totalTime = startTime - DateTime.Now;

            return Ok($"Done! Handler duration: {totalTime.Duration()}");
        }
    }
}