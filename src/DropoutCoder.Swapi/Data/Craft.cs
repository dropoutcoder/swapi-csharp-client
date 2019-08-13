using System.Collections.Generic;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public abstract class Craft : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            internal set;
        }

        [JsonProperty("model")]
        public string Model {
            get;
            internal set;
        }

        [JsonProperty("manufacturer")]
        public string Manufacturer {
            get;
            internal set;
        }

        [JsonProperty("cost_in_credits")]
        public string Price {
            get;
            internal set;
        }

        [JsonProperty("length")]
        public string Length {
            get;
            internal set;
        }

        [JsonProperty("max_atmosphering_speed")]
        public string MaxAtmosphericSpeed {
            get;
            internal set;
        }

        [JsonProperty("crew")]
        public string Crew {
            get;
            internal set;
        }

        [JsonProperty("passengers")]
        public string Passengers {
            get;
            internal set;
        }

        [JsonProperty("cargo_capacity")]
        public string CargoCapacity {
            get;
            internal set;
        }

        [JsonProperty("consumables")]
        public string Consumables {
            get;
            internal set;
        }

        [JsonProperty("pilots")]
        public IEnumerable<SwapiEntityReference<CharacterCollection>> Characters {
            get;
            internal set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<MovieCollection>> Movies {
            get;
            internal set;
        }
    }
}
