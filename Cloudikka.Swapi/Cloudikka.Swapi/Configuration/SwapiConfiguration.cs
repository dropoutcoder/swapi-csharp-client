using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi.Configuration {
    public class SwapiConfiguration {
        public SwapiConfiguration(Uri baseAddress) {
            if(baseAddress == null) {
                throw new ArgumentNullException(nameof(baseAddress));
            }

            this.BaseAddress = baseAddress;
        }

        public Uri BaseAddress {
            get;
            private set;
        }
    }
}
