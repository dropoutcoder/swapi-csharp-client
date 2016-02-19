using Cloudikka.Swapi.Conversion.Json;
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

        [JsonProperty("birth_year")]
        public string YearOfBirth {
            get; set;
        }

        [JsonProperty("gender")]
        public string Gender {
            get; set;
        }

        [JsonProperty("homeworld")]
        public SwapiEntityReference<Planet> Homeworld {
            get; set;
        }

        [JsonProperty("species")]
        public IEnumerable<SwapiEntityReference<Species>> Species {
            get; set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<Movie>> Movies {
            get; set;
        }

        [JsonProperty("starships")]
        public IEnumerable<SwapiEntityReference<Starship>> Starships {
            get; set;
        }

        [JsonProperty("vehicles")]
        public IEnumerable<SwapiEntityReference<Vehicle>> Vehicles {
            get; set;
        }
    }
}
