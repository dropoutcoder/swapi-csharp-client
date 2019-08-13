using System.Collections.Generic;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Character : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            internal set;
        }

        [JsonProperty("height")]
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

        [JsonProperty("birth_year")]
        public string YearOfBirth {
            get;
            internal set;
        }

        [JsonProperty("gender")]
        public string Gender {
            get;
            internal set;
        }

        [JsonProperty("homeworld")]
        public SwapiEntityReference<Planet> Homeworld {
            get;
            internal set;
        }

        [JsonProperty("species")]
        public IEnumerable<SwapiEntityReference<Species>> Species {
            get;
            internal set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<Movie>> Movies {
            get;
            internal set;
        }

        [JsonProperty("starships")]
        public IEnumerable<SwapiEntityReference<Starship>> Starships {
            get;
            internal set;
        }

        [JsonProperty("vehicles")]
        public IEnumerable<SwapiEntityReference<Vehicle>> Vehicles {
            get;
            internal set;
        }
    }
}
