using System;
using Lx.Utilities.Contracts.Infrastructure;

namespace Lx.Utilities.Xamarin.Etc {
    public abstract class ResultBase {
        protected ResultBase() {
            TimeCreated = DateTimeOffset.UtcNow;
        }

        public ProcessResult ProcessResult { get; set; }
        public DateTimeOffset TimeCreated { get; }
    }
}