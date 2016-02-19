using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Root : SwapiEntity {
        [JsonProperty("people")]
        public SwapiCollectionReference<Character> Characters {
            get; set;
        }

        [JsonProperty("planets")]
        public SwapiCollectionReference<Planet> Planets {
            get; set;
        }

        [JsonProperty("films")]
        public SwapiCollectionReference<Movie> Movies {
            get; set;
        }

        [JsonProperty("species")]
        public SwapiCollectionReference<Species> Species {
            get; set;
        }

        [JsonProperty("vehicles")]
        public SwapiCollectionReference<Vehicle> Vehicles {
            get; set;
        }

        [JsonProperty("starships")]
        public SwapiCollectionReference<Starship> Starships {
            get; set;
        }
    }
}
