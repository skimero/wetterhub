using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetterhub.Models.DTO
{
    public class Components
    {
        [JsonProperty("co")]
        public double Co { get; set; }

        [JsonProperty("no")]
        public double No { get; set; }

        [JsonProperty("no2")]
        public double No2 { get; set; }

        [JsonProperty("o3")]
        public double O3 { get; set; }

        [JsonProperty("so2")]
        public double So2 { get; set; }

        [JsonProperty("pm2_5")]
        public double Pm25 { get; set; }

        [JsonProperty("pm10")]
        public double Pm10 { get; set; }

        [JsonProperty("nh3")]
        public double Nh3 { get; set; }
    }

    public class CoordLuft
    {
        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }
    }

    public class List
    {
        [JsonProperty("main")]
        public AirQuality AirQuality { get; set; }

        [JsonProperty("components")]
        public Components Components { get; set; }

        [JsonProperty("dt")]
        public int Dt { get; set; }
    }

    public class AirQuality
    {
        [JsonProperty("aqi")]
        public int Aqi { get; set; }
    }

    public class LuftDTO
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("list")]
        public List<List> List { get; set; }
    }

}
