using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Root : SwapiObject {
        [JsonProperty("people")]
        public SwapiEntityReference<CharacterCollectionPage> Characters {
            get; set;
        }

        [JsonProperty("planets")]
        public SwapiEntityReference<PlanetCollectionPage> Planets {
            get; set;
        }

        [JsonProperty("films")]
        public SwapiEntityReference<MovieCollectionPage> Movies {
            get; set;
        }

        [JsonProperty("species")]
        public SwapiEntityReference<SpeciesCollectionPage> Species {
            get; set;
        }

        [JsonProperty("vehicles")]
        public SwapiEntityReference<VehicleCollectionPage> Vehicles {
            get; set;
        }

        [JsonProperty("starships")]
        public SwapiEntityReference<StarshipCollectionPage> Starships {
            get; set;
        }
    }
}
