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


        public async Task<ActionResult> SampleSeven()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();

            // Begin the async calls.
            Task<Models.PerformanceResult> firstCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            Task<Models.PerformanceResult> secondCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            Task<Models.PerformanceResult> thirdCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            Task<Models.PerformanceResult> fourthCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            Task<Models.PerformanceResult> fifthCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            Task<Models.PerformanceResult> sixthCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");

            // Wait for the calls to complete.
            // Note: `var results = await Task.WhenAll(firstCall, ..., sixthCall);` does the same thing, but the
            // results are placed in an array.
            ViewBag.Site1 = await firstCall;
            ViewBag.Site2 = await secondCall;
            ViewBag.Site3 = await thirdCall;
            ViewBag.Site4 = await fourthCall;
            ViewBag.Site5 = await fifthCall;
            ViewBag.Site6 = await sixthCall;

            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }

        public async Task<ActionResult> SampleEight()
        {
            Stopwatch actionTimer = new Stopwatch();
            actionTimer.Start();

            // Begin the async calls.
            Task<Models.PerformanceResult> firstCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com");
            Task<Models.PerformanceResult> secondCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 250);
            Task<Models.PerformanceResult> thirdCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 500);
            Task<Models.PerformanceResult> fourthCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 750);
            Task<Models.PerformanceResult> fifthCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 1300);
            Task<Models.PerformanceResult> sixthCall = Utils.VerifyURLUpAsync("https://www.smoothfusion.com", 2500);

            // Wait for the calls to complete.
            ViewBag.Site1 = await firstCall;
            ViewBag.Site2 = await secondCall;
            ViewBag.Site3 = await thirdCall;
            ViewBag.Site4 = await fourthCall;
            ViewBag.Site5 = await fifthCall;
            ViewBag.Site6 = await sixthCall;

            actionTimer.Stop();
            ViewBag.PageLoadTime = Utils.FormatTimeSpan(actionTimer.Elapsed);
            return View();
        }
    }
}