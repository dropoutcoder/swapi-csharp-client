using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public class SwapiCollection<T> : SwapiObject
        where T : SwapiEntity {
        [JsonProperty("count")]
        public int Count {
            get;
            set;
        }

        [JsonProperty("next")]
        public Uri Next {
            get;
            set;
        }

        [JsonProperty("previous")]
        public Uri Previous {
            get;
            set;
        }

        [JsonProperty("results")]
        public IEnumerable<T> Collection {
            get;
            set;
        }

        public SwapiCollection<T> Merge(SwapiCollection<T> collection) {
            this.Collection = collection.Collection.Concat(this.Collection);
            return this;
        }
    }
}
