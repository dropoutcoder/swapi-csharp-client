using System.Collections.Generic;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Species : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            internal set;
        }

        [JsonProperty("classification")]
        public string Classification {
            get;
            internal set;
        }

        [JsonProperty("designation")]
        public string Designation {
            get;
            internal set;
        }

        [JsonProperty("average_height")]
        public string Height {
            get;
            internal set;
        }

        [JsonProperty("hair_color")]
        public string HairColor {
            get;
            internal set;
        }

        [JsonProperty("skin_color")]
        public string SkinColor {
            get;
            internal set;
        }

        [JsonProperty("eye_color")]
        public string EyeColor {
            get;
            internal set;
        }

        [JsonProperty("average_lifespan")]
        public string AverageLifespan {
            get;
            internal set;
        }

        [JsonProperty("language")]
        public string Language {
            get;
            internal set;
        }

        [JsonProperty("homeworld")]
        public SwapiEntityReference<Planet> Homeworld {
            get;
            internal set;
        }

        [JsonProperty("people")]
        public IEnumerable<SwapiEntityReference<Character>> Characters {
            get;
            internal set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<Movie>> Movies {
            get;
            internal set;
        }
    }
}
