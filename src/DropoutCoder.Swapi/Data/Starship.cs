using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
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
        public string MaxMegaLightsSpeed {
            get;
            set;
        }
    }
}
