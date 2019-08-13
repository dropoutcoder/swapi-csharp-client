using System.Collections.Generic;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class Planet : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            internal set;
        }

        [JsonProperty("rotation_period")]
        public string RotationPeriod {
            get;
            internal set;
        }

        [JsonProperty("orbital_period")]
        public string OrbitalPeriod {
            get;
            internal set;
        }

        [JsonProperty("diameter")]
        public string Diameter {
            get;
            internal set;
        }

        [JsonProperty("climate")]
        public string Climate {
            get;
            internal set;
        }

        [JsonProperty("gravity")]
        public string Gravity {
            get;
            internal set;
        }

        [JsonProperty("terrain")]
        public string Terrain {
            get;
            internal set;
        }

        [JsonProperty("surface_water")]
        public string WaterCoverage {
            get;
            internal set;
        }

        [JsonProperty("population")]
        public string Population {
            get;
            internal set;
        }

        [JsonProperty("residents")]
        public IEnumerable<SwapiEntityReference<Character>> Residents {
            get;
            internal set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<Movie>> Movies {
            get;
            internal set;
        }
    }
}
