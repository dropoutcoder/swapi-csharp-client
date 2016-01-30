using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Starship : Craft {
        [JsonProperty("starship_class")]
        public string Class {
            get;
            set;
        }

        [JsonProperty("hyperdrive_rating")]
        public string HyperdriveRating {
            get;
            set;
        }

        [JsonProperty("MGLT")]
        public double MaxMegalightsSpeed {
            get;
            set;
        }
    }
}
