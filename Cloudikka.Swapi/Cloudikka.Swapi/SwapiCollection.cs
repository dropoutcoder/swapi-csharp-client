using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public abstract class SwapiCollection<T>
        where T : SwapiEntity {
        public IEnumerable<SwapiCollectionPage<T>> Pages {
            get;
            set;
        }
    }
}
