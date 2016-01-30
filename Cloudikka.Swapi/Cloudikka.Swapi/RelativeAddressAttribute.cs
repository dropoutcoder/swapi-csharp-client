using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloudikka.Swapi {
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class RelativeAddressAttribute : Attribute {
        public RelativeAddressAttribute(string relativeAddress) {
            if(String.IsNullOrWhiteSpace(relativeAddress)) {
                throw new ArgumentException("Parameter relatveAddress cannot be null -or- empty -or- whitespace", nameof(relativeAddress));   
            }

            Uri relativeUri;

            if(!Uri.TryCreate(relativeAddress, UriKind.Relative, out relativeUri)) {
                /// TODO: Describe reasonable exception message
                throw new InvalidOperationException();
            };

            this.RelativeAddress = relativeUri;
        }

        public Uri RelativeAddress {
            get;
            private set;
        }
    }
}
