using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace RepositoryPull.Api
{
    abstract public class BaseApi
    {
        // Get request by url .
        // Params url, useragent.
        // Useragent header for in mandatory conditions.
        protected static string Get(string url, string userAgent = null)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            // Github api blocks requests with empty useragent.
            if (userAgent != null)
            {
                req.UserAgent = userAgent;
            }

            req.ContentType = "text/html";
            req.Method = "GET";

            using (System.Net.WebResponse resp = req.GetResponse())
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream()))
                {
                    return sr.ReadToEnd().Trim();
                }
            }

        }
    }
}