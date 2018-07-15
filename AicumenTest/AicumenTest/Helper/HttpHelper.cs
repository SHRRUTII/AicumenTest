using AicumenTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AicumenTest.Helper
{
    /// <summary>
    /// HttpHelper 
    /// </summary>
    /// <param name="wibble">Wibble factor</param>
    public class HttpHelper
    {
        ObservableCollection<Crypto> _Cryptos = new ObservableCollection<Crypto>();

        /// <summary>
        /// GetTop10Cryptos API
        /// </summary>
        /// <param name="RequestUrl">Request Url</param>    
        public static async Task<HttpResponseMessage> GetTop10Cryptos(string RequestUrl)
        {
            HttpResponseMessage responseMessage = null;
            using (var c = new HttpClient())
            {
                var client = new System.Net.Http.HttpClient();
                responseMessage = await client.GetAsync(new Uri(RequestUrl));              
            }
            return responseMessage;
        }
    }
}
