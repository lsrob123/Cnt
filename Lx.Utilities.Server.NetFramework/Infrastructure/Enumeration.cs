using System.ComponentModel.DataAnnotations;
using Lx.Utilities.Contracts.Infrastructure;

namespace Lx.Utilities.Server.NetFramework.Infrastructure
{
    public abstract class Enumeration : Contracts.Infrastructure.Enumeration
    {
        protected Enumeration()
        {
        }

        protected Enumeration(int value, string name) : base(value, name)
        {
        }

        protected Enumeration(Contracts.Infrastructure.Enumeration other) : base(other)
        {
        }

        [MaxLength(128)]
        public override string Name { get; set; }
    }
}