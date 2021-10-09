using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopeApplication.Models
{
    public class Horoscope
    {
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "compatibility")]
        public string Compatibility { get; set; }

        [JsonProperty(PropertyName = "current_date")]
        public string Current_date { get; set; }

        [JsonProperty(PropertyName = "date_range")]
        public string Date_range { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "lucky_number")]
        public string Lucky_number { get; set; }

        [JsonProperty(PropertyName = "lucky_time")]
        public string Lucky_time { get; set; }

        [JsonProperty(PropertyName = "mood")]
        public string Mood { get; set; }
    }
}
