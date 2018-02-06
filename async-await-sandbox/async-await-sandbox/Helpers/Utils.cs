using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using async_await_sandbox.Models;
using Newtonsoft.Json;

namespace async_await_sandbox.Helpers
{
    public class Utils
    {

        private static HttpClient client = new HttpClient();

        public static async Task<PerformanceResult> VerifyURLUpAsync(string URL, int delay = 0)
        {
            Stopwatch lookupTimer = new Stopwatch();
            lookupTimer.Start();

            if (delay > 0)
                await Delay(delay);

           
            var ok = false;
            try
            {
                HttpResponseMessage response = await client.GetAsync(URL);
                response.EnsureSuccessStatusCode();  // if anything but a good status is returned it will fail here
                //string responseBody = await response.Content.ReadAsStringAsync();
                
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
                lookupTimer.Stop();
                return new PerformanceResult() { LoadTime = FormatTimeSpan(lookupTimer.Elapsed), OK = false, URL = URL };
                
            }
            finally {
                //client.Dispose();
            }

            lookupTimer.Stop();
            return new PerformanceResult() { LoadTime = FormatTimeSpan(lookupTimer.Elapsed), OK = true, URL = URL };

        }

        public static PerformanceResult VerifyURLUp(string URL, int delay = 0)
        {
            Stopwatch lookupTimer = new Stopwatch();
            lookupTimer.Start();
            var ok = true;
            try
            {
                var request = WebRequest.Create(URL) as HttpWebRequest;
                request.Method = "HEAD";
                
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        ok = false;
                }
            }
            catch (Exception err)
            {
                ok = false;
            }
            if (delay > 0)
                Thread.Sleep(delay);
            lookupTimer.Stop();
            return new PerformanceResult() { LoadTime = FormatTimeSpan(lookupTimer.Elapsed), OK = ok, URL = URL };

        }

        private static async Task Delay(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }

        public static string FormatTimeSpan(TimeSpan ts)
        {
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            return elapsedTime;
        }

    }
}