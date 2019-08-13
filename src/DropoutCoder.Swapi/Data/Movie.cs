using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Movie : SwapiEntity {
        [JsonProperty("title")]
        public string Title {
            get;
            internal set;
        }

        [JsonProperty("episode_id")]
        public string Episode {
            get;
            internal set;
        }

        [JsonProperty("opening_crawl")]
        public string Introduction {
            get;
            internal set;
        }

        [JsonProperty("director")]
        public string Director {
            get;
            internal set;
        }

        [JsonProperty("producer")]
        public string Producer {
            get;
            internal set;
        }

        [JsonProperty("release_date")]
        public DateTime Released {
            get;
            internal set;
        }

        [JsonProperty("characters")]
        public IEnumerable<SwapiEntityReference<Character>> Characters {
            get;
            internal set;
        }

        [JsonProperty("planets")]
        public IEnumerable<SwapiEntityReference<Planet>> Planets {
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

        [JsonProperty("species")]
        public IEnumerable<SwapiEntityReference<Species>> Species {
            get;
            internal set;
        }
    }
}
