using Cloudikka.Swapi.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public class SwapiClient {
        public SwapiClient() {
            this.Configuration = DefaultSwapiConfiguration.Create();
            this.HttpClient = new HttpClient();
        }

        public SwapiClient(SwapiConfiguration config) {
            if(config == null) {
                throw new ArgumentNullException(nameof(config));
            }

            this.Configuration = config;
        }

        public SwapiConfiguration Configuration {
            get;
            private set;
        }
        public HttpClient HttpClient {
            get;
            private set;
        }

        public async Task<T> GetAsync<T>(SwapiReference<T> reference)
            where T : SwapiObject, new() {
            if(reference == null) {
                throw new ArgumentNullException(nameof(reference));
            }

            if(reference.Url == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            if(this.HttpClient == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            if(this.Configuration == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            var response = await this.HttpClient.GetAsync(reference.Url);

            if(response.IsSuccessStatusCode) {
                /// TODO: Handle json parsing errors
                try {
                    var json = await response.Content.ReadAsStringAsync();
                    reference.Value = JsonConvert.DeserializeObject<T>(json);

                    return reference.Value;
                } catch (JsonSerializationException jse) {
                    Debug.WriteLineIf(!String.IsNullOrWhiteSpace(jse.Message), jse.Message);
                    throw;
                }                
            } else {
                /// TODO: Handle better failed requests
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }
    }
}
