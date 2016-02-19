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
        public string Episode {
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
        public IEnumerable<SwapiEntityReference<Character>> Characters {
            get; set;
        }

        [JsonProperty("planets")]
        public IEnumerable<SwapiEntityReference<Planet>> Planets {
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

        [JsonProperty("species")]
        public IEnumerable<SwapiEntityReference<Species>> Species {
            get; set;
        }
    }
}
