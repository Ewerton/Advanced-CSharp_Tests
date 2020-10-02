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
        public async Task<RequestResult> GetWordCountInWebSiteAsync(string URL, string word)
        {
            // The await keyword here, suspends GetWordCountInWebSite() to allow the caller (the web server) or the interface
            // to accept another request, rather than blocking on this one.


            // Its like the following line is one simgle Method() and the rest of this GetWordCountInWebSiteAsync() is another method
            // that works as callback for GetWordCountInWebSiteAsync()
            var html = await _httpClient.GetStringAsync(URL);

            // It like the following lines is the callback method for the "await _httpClient.GetStringAsync(URL)" line
            word = word.Trim();
            RequestResult r = new RequestResult();
            r.Word = word;
            r.Count = Regex.Matches(html, @"(?:^|\W)" + word + @"(?:$|\W)", RegexOptions.IgnoreCase).Count;
            r.FinishedAt = DateTime.Now;
            return r;
        }
    }
}
