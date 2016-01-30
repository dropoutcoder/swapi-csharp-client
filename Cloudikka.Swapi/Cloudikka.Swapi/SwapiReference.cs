using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    public class SwapiReference<T> : SwapiObject
        where T : SwapiObject, new() {
        public T Value {
            get;
            set;
        }
    }
}
