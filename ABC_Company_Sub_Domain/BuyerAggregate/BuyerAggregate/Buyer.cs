using System;

namespace BuyerAggregate
{
    public class Buyer
    {
        public string IdentityGuid { get; private set; }

        public string Name { get; private set; }

        protected Buyer()
        {

        }

        public Buyer(string identity, string name) : this()
        {
            IdentityGuid = !string.IsNullOrWhiteSpace(identity) ? identity : throw new ArgumentNullException(nameof(identity));
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
        }

    }
}
