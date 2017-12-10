using System.ComponentModel.DataAnnotations;
using Lx.Utilities.Services.Infrastructure;

namespace Lx.Utilities.Server.Infrastructure
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