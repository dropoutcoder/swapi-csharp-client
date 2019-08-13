using System.Collections.Generic;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Species : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            set;
        }

        [JsonProperty("classification")]
        public string Classification {
            get;
            set;
        }

        [JsonProperty("designation")]
        public string Designation {
            get;
            set;
        }

        [JsonProperty("average_height")]
        public string Height {
            get;
            set;
        }

        [JsonProperty("hair_color")]
        public string HairColor {
            get; set;
        }

        [JsonProperty("skin_color")]
        public string SkinColor {
            get; set;
        }

        [JsonProperty("eye_color")]
        public string EyeColor {
            get; set;
        }

        [JsonProperty("average_lifespan")]
        public string AverageLifespan {
            get; set;
        }

        [JsonProperty("language")]
        public string Language {
            get; set;
        }

        [JsonProperty("homeworld")]
        public SwapiEntityReference<Planet> Homeworld {
            get; set;
        }

        [JsonProperty("people")]
        public IEnumerable<SwapiEntityReference<Character>> Characters {
            get; set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<Movie>> Movies {
            get; set;
        }
    }
}
