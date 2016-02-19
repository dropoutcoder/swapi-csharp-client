using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Data {
    public class Planet : SwapiEntity {
        [JsonProperty("name")]
        public string Name {
            get;
            set;
        }

        [JsonProperty("rotation_period")]
        public int RotationPeriod {
            get;
            set;
        }

        [JsonProperty("orbital_period")]
        public int OrbitalPeriod {
            get;
            set;
        }

        [JsonProperty("diameter")]
        public int Diameter {
            get;
            set;
        }

        [JsonProperty("climate")]
        public string Climate {
            get;
            set;
        }

        [JsonProperty("gravity")]
        public string Gravity {
            get;
            set;
        }

        [JsonProperty("terrain")]
        public string Terrain {
            get;
            set;
        }

        [JsonProperty("surface_water")]
        public int WaterCoverage {
            get;
            set;
        }

        [JsonProperty("population")]
        public long Population {
            get;
            set;
        }

        [JsonProperty("residents")]
        public IEnumerable<SwapiEntityReference<Character>> Residents {
            get; set;
        }

        [JsonProperty("films")]
        public IEnumerable<SwapiEntityReference<Movie>> Movies {
            get; set;
        }
    }
}
