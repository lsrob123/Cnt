using System;
using Lx.Utilities.Contracts.Infrastructure;

namespace Lx.Utilities.Xamarin.Etc {
    public class ResultBase {
        public ResultBase() {
            TimeCreated = DateTimeOffset.UtcNow;
        }

        public ProcessResult ProcessResult { get; set; }
        public DateTimeOffset TimeCreated { get; }
    }
}