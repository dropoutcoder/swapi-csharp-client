using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    public class SwapiCollection<T> : SwapiObject
        where T : SwapiEntity {
        [JsonProperty("count")]
        public int Count {
            get;
            internal set;
        }

        [JsonProperty("next")]
        public Uri Next {
            get;
            internal set;
        }

        [JsonProperty("previous")]
        public Uri Previous {
            get;
            internal set;
        }

        [JsonProperty("results")]
        public IEnumerable<T> Collection {
            get;
            internal set;
        }

        public SwapiCollection<T> Merge(SwapiCollection<T> collection) {
            this.Collection = collection.Collection.Concat(this.Collection);
            return this;
        }
    }
}
