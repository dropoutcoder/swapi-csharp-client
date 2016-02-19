using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public abstract class Craft : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            set;
        }

        [JsonProperty("model")]
        public string Model {
            get;
            set;
        }
 
        [JsonProperty("manufacturer")]
        public string Manufacturer {
            get;
            set;
        }

        [JsonProperty("cost_in_credits")]
        public string Price {
            get;
            set;
        }

        [JsonProperty("length")]
        public string Length {
            get;
            set;
        }

        [JsonProperty("max_atmosphering_speed")]
        public string MaxAtmosphericSpeed {
            get;
            set;
        }

        [JsonProperty("crew")]
        public string Crew {
            get;
            set;
        }
         
        [JsonProperty("passengers")]
        public string Passengers {
            get;
            set;
        }

        [JsonProperty("cargo_capacity")]
        public string CargoCapacity {
            get;
            set;
        }
             
        [JsonProperty("consumables")]
        public string Consumables {
            get;
            set;
        }

        [JsonProperty("pilots")]
        public IEnumerable<SwapiEntityReference<CharacterCollectionPage>> Characters {
            get; set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<MovieCollectionPage>> Movies {
            get; set;
        }
    }
}
