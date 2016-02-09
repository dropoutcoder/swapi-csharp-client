using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
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
        public int Height {
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
        public SwapiReference<Planet> Homeworld {
            get; set;
        }

        [JsonProperty("people")]
        public SwapiReference<CharacterCollectionPage> Characters {
            get; set;
        }

        [JsonProperty("films")]
        public SwapiReference<MovieCollectionPage> Movies {
            get; set;
        }
    }
}
