using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AicumenTest.Models
{
    /// <summary>
    /// Crypto model
    /// </summary>
    public class Crypto
    {
        [JsonProperty("id")]        
        public string id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("price_usd")]
        public string Price_USD { get; set; }

        [JsonProperty("price_btc")]
        public string Price_BTC { get; set; }

        [JsonProperty("24h_volume_usd")]
        public string Volume_USD { get; set; }

        [JsonProperty("market_cap_usd")]
        public float Market_Cap_USD { get; set; }

        [JsonProperty("available_supply")]
        public string Available_Supply { get; set; }

        [JsonProperty("total_supply")]
        public string Total_Supply { get; set; }

        [JsonProperty("max_supply")]
        public string Max_Supply { get; set; }

        [JsonProperty("percent_change_1h")]
        public string Percent_change_1h { get; set; }

        [JsonProperty("percent_change_24hh")]
        public string Percent_change_24h { get; set; }

        [JsonProperty("percent_change_7d")]
        public string Percent_change_7d { get; set; }

        [JsonProperty("last_Updated")]
        public string Last_Updated { get; set; }
    }
}
