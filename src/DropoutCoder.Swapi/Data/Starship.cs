using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Starship : Craft {
        [JsonProperty("starship_class")]
        public string Class {
            get;
            internal set;
        }

        [JsonProperty("hyperdrive_rating")]
        public string HyperdriveRating {
            get;
            internal set;
        }

        [JsonProperty("MGLT")]
        public string MaxMegaLightsSpeed {
            get;
            internal set;
        }
    }
}
