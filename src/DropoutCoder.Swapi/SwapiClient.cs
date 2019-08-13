using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using DropoutCoder.Swapi.Configuration;
using DropoutCoder.Swapi.Data;
using Newtonsoft.Json;

namespace DropoutCoder.Swapi {
    public class SwapiClient {
        public SwapiClient() {
            this.Configuration = DefaultSwapiConfiguration.Create();
            this.HttpClient = new HttpClient();
        }

        public SwapiClient(SwapiConfiguration config) {
            if (config == null) {
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

        public async Task<T> GetAsync<T>(SwapiEntityReference<T> reference)
            where T : SwapiEntity, new() {
            if (reference == null) {
                throw new ArgumentNullException(nameof(reference));
            }

            if (reference.Url == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            if (this.HttpClient == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            if (this.Configuration == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            var response = await this.HttpClient.GetAsync(reference.Url);

            if (response.IsSuccessStatusCode) {
                /// TODO: Handle json parsing errors
                try {
                    using (var stream = await response.Content.ReadAsStreamAsync()) {
                        using (var streamReader = new StreamReader(stream)) {
                            using (var jsonReader = new JsonTextReader(streamReader)) {
                                var serializer = new JsonSerializer();

                                reference.Value = serializer.Deserialize<T>(jsonReader);

                                return reference.Value;
                            }
                        }
                    }
                } catch (JsonSerializationException jse) {
                    Debug.WriteLineIf(!String.IsNullOrWhiteSpace(jse.Message), jse.Message);
                    throw;
                }
            } else {
                /// TODO: Handle better failed requests
                throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        public async Task<SwapiCollection<T>> GetCollectionAsync<T>(SwapiCollectionReference<T> reference)
            where T : SwapiEntity, new() {
            if (reference == null) {
                throw new ArgumentNullException(nameof(reference));
            }

            if (reference.Url == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            if (this.HttpClient == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }

            if (this.Configuration == null) {
                /// TODO: Describe exception with reasonable message
                throw new InvalidOperationException();
            }
            do {
                var response = await this.HttpClient.GetAsync(reference.Url);

                if (response.IsSuccessStatusCode) {

                    /// TODO: Handle json parsing errors
                    try {
                        using (var stream = await response.Content.ReadAsStreamAsync()) {
                            using (var streamReader = new StreamReader(stream)) {
                                using (var jsonReader = new JsonTextReader(streamReader)) {
                                    var serializer = new JsonSerializer();

                                    var result = serializer.Deserialize<SwapiCollection<T>>(jsonReader);

                                    if (reference.Value == null) {
                                        reference.Value = result;
                                    } else {
                                        reference.Value = result.Merge(reference.Value);
                                    }

                                    reference.Url = result.Next;
                                }
                            }
                        }
                    } catch (Exception e) {
                        Debug.WriteLineIf(!String.IsNullOrWhiteSpace(e.Message), e.Message);
                        throw;
                    }
                } else {
                    /// TODO: Handle better failed requests
                    throw new HttpRequestException(response.ReasonPhrase);
                }
            } while (reference.Url != null);

            return reference.Value;
        }

        public async Task<Root> GetAllAsync() {
            var root = await this.GetAsync<Root>(new SwapiEntityReference<Root> { Url = Configuration.BaseAddress });

            var characters = await this.GetCollectionAsync(root.Characters);
            var movies = await this.GetCollectionAsync(root.Movies);
            var planets = await this.GetCollectionAsync(root.Planets);
            var species = await this.GetCollectionAsync(root.Species);
            var starships = await this.GetCollectionAsync(root.Starships);
            var vehicles = await this.GetCollectionAsync(root.Vehicles);

            return root;
        }
    }
}
