using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Character : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            set;
        }

        [JsonProperty("height")]
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

        [JsonProperty("birth_year")]
        public string YearOfBirth {
            get; set;
        }

        [JsonProperty("gender")]
        public string Gender {
            get; set;
        }

        [JsonProperty("homeworld")]
        public SwapiReference<Planet> Homeworld {
            get; set;
        }

        [JsonProperty("species")]
        public IEnumerable<SwapiReference<Species>> Species {
            get; set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiReference<Movie>> Movies {
            get; set;
        }

        [JsonProperty("starships")]
        public IEnumerable<SwapiReference<Starship>> Starships {
            get; set;
        }

        [JsonProperty("vehicles")]
        public IEnumerable<SwapiReference<Vehicle>> Vehicles {
            get; set;
        }
    }
}
