using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Movie : SwapiEntity {
        [JsonProperty("title")]
        public string Title {
            get; set;
        }

        [JsonProperty("episode_id")]
        public int Episode {
            get; set;
        }

        [JsonProperty("opening_crawl")]
        public string Introduction {
            get; set;
        }

        [JsonProperty("director")]
        public string Director {
            get; set;
        }

        [JsonProperty("producer")]
        public string Producer {
            get; set;
        }

        [JsonProperty("release_date")]
        public DateTime Released {
            get;
            set;
        }

        [JsonProperty("characters")]
        public SwapiReference<CharacterCollectionPage> Characters {
            get; set;
        }

        [JsonProperty("planets")]
        public SwapiReference<PlanetCollectionPage> Planets {
            get; set;
        }

        [JsonProperty("starships")]
        public SwapiReference<StarshipCollectionPage> Starships {
            get; set;
        }

        [JsonProperty("vehicles")]
        public SwapiReference<VehicleCollectionPage> Vehicles {
            get; set;
        }

        [JsonProperty("species")]
        public SwapiReference<SpeciesCollectionPage> Species {
            get; set;
        }
    }
}
