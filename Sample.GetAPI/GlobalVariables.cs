using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;


namespace Sample.GetAPI
{
    public static class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

       static GlobalVariables()
        {
            string _baseAddress = "http://od.moi.gov.tw/od/data/api/";
            WebApiClient.BaseAddress = new Uri(_baseAddress);
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
        }
    }
}