using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using async_await_sandbox.Helpers;
using System.Threading.Tasks;

namespace async_await_sandbox.Controllers
{
    public class SamplesController : Controller
    {
        public ActionResult SampleOne()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site1 = Utils.VerifyURLUp("https://www.smoothfusion.com");
            ViewBag.Site2 = Utils.VerifyURLUp("https://www.smoothfusion.com");
            ViewBag.Site3 = Utils.VerifyURLUp("https://www.smoothfusion.com");
            ViewBag.Site4 = Utils.VerifyURLUp("https://www.smoothfusion.com");
            ViewBag.Site5 = Utils.VerifyURLUp("https://www.smoothfusion.com");
            ViewBag.Site6 = Utils.VerifyURLUp("https://www.smoothfusion.com");



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }

        public ActionResult SampleTwo()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site1 = Utils.VerifyURLUp("https://www.smoothfusion.com");
            ViewBag.Site2 = Utils.VerifyURLUp("https://www.smoothfusion.com", 250);
            ViewBag.Site3 = Utils.VerifyURLUp("https://www.smoothfusion.com", 500);
            ViewBag.Site4 = Utils.VerifyURLUp("https://www.smoothfusion.com", 750);
            ViewBag.Site5 = Utils.VerifyURLUp("https://www.smoothfusion.com", 1300);
            ViewBag.Site6 = Utils.VerifyURLUp("https://www.smoothfusion.com", 2500);



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }


        public async Task<ActionResult> SampleThree()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site1 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            ViewBag.Site2 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 0);
            ViewBag.Site3 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 0);
            ViewBag.Site4 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 0);
            ViewBag.Site5 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 0);
            ViewBag.Site6 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 0);



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }

        public async Task<ActionResult> SampleFour()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site1 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            ViewBag.Site2 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 250);
            ViewBag.Site3 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 500);
            ViewBag.Site4 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 750);
            ViewBag.Site5 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 1300);
            ViewBag.Site6 = await Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 2500);



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }

        public async Task<ActionResult> SampleFive()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site1 = "https://www.smoothfusion.com";
            ViewBag.Site2 = "https://www.smoothfusion.com";
            ViewBag.Site3 = "https://www.smoothfusion.com";
            ViewBag.Site4 = "https://www.smoothfusion.com";
            ViewBag.Site5 = "https://www.smoothfusion.com";
            ViewBag.Site6 = "https://www.smoothfusion.com";



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }

        public async Task<ActionResult> SampleSix()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site1 = "https://www.smoothfusion.com";
            ViewBag.Site2 = "https://www.smoothfusion.com";
            ViewBag.Site3 = "https://www.smoothfusion.com";
            ViewBag.Site4 = "https://www.smoothfusion.com";
            ViewBag.Site5 = "https://www.smoothfusion.com";
            ViewBag.Site6 = "https://www.smoothfusion.com";



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }

        public async Task<ActionResult> SiteResults(string url, int delay = 0)
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();


            ViewBag.Site = await Utils.VerifyURLUpAsync(url, delay);



            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return PartialView("_SiteResults");
        }

    }
}