using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Root : SwapiEntity {
        [JsonProperty("people")]
        public SwapiCollectionReference<Character> Characters {
            get;
            internal set;
        }

        [JsonProperty("planets")]
        public SwapiCollectionReference<Planet> Planets {
            get;
            internal set;
        }

        [JsonProperty("films")]
        public SwapiCollectionReference<Movie> Movies {
            get;
            internal set;
        }

        [JsonProperty("species")]
        public SwapiCollectionReference<Species> Species {
            get;
            internal set;
        }

        [JsonProperty("vehicles")]
        public SwapiCollectionReference<Vehicle> Vehicles {
            get;
            internal set;
        }

        [JsonProperty("starships")]
        public SwapiCollectionReference<Starship> Starships {
            get;
            internal set;
        }
    }
}
