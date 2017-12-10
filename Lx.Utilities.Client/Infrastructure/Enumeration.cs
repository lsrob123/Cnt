using Lx.Utilities.Services.Infrastructure;
using SQLite;

namespace Lx.Utilities.Client.Infrastructure
{
    public abstract class Enumeration : EnumerationBase
    {
        protected Enumeration()
        {
        }

        protected Enumeration(int value, string name) : base(value, name)
        {
        }

        protected Enumeration(EnumerationBase other) : base(other)
        {
        }

        [MaxLength(128)]
        public override string Name { get; set; }
    }
}