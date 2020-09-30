using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitLib
{
    public class IOBoundOperation
    {
        private readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// I/O bound operation which counts how many words exists in a webpage
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public async Task<RequestResult> GetWordCountInWebSite(string URL, string word)
        {
            // The await keyword here, suspends GetWordCountInWebSite() to allow the caller (the web server) or the interface
            // to accept another request, rather than blocking on this one.

            // Simulates high and variable latency for each request
            //Thread.Sleep(word.Length * 500);

            var html = await _httpClient.GetStringAsync(URL);

            word = word.Trim();
            RequestResult r = new RequestResult();
            r.Word = word;
            r.Count = Regex.Matches(html, @"(?:^|\W)" + word + @"(?:$|\W)", RegexOptions.IgnoreCase).Count;
            r.FinishedAt = DateTime.Now;
            return r;
        }
    }
}
