using System;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi.Conversion.Json {
    public class SwapiReferenceConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            var typeDefinition = typeof(SwapiEntityReference<>);

            if (objectType.GetGenericTypeDefinition() == typeDefinition) {
                return true;
            }

            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if (reader.TokenType == JsonToken.String) {
                Uri uri;

                if (Uri.TryCreate(reader.Value as string, UriKind.RelativeOrAbsolute, out uri)) {
                    var result = Activator.CreateInstance(objectType) as SwapiReference;
                    result.Url = uri;

                    return result;
                }
            }

            return existingValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }
    }
}
