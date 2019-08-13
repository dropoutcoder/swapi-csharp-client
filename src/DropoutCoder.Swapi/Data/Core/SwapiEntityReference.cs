using DropoutCoder.Swapi.Conversion.Json;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Data {
    [JsonConverter(typeof(SwapiReferenceConverter))]
    public class SwapiEntityReference<T> : SwapiReference
        where T : SwapiObject, new() {
        [JsonIgnore()]
        public T Value {
            get;
            internal set;
        }
    }
}
