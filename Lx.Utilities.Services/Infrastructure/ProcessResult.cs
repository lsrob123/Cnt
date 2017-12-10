using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using Lx.Utilities.Contracts.Infrastructure;
using Newtonsoft.Json;

namespace Lx.Utilities.Services.Infrastructure
{
    public class ProcessResult
    {
        public ProcessResult()
        {
        }

        public ProcessResult(ProcessResultType type, Exception exception,
            string resultReference = null, bool logExcetions = true)
            : this(type, new List<Exception> {exception}, resultReference, logExcetions)
        {
            ExtractProcessResultTypeFromException();
        }

        public ProcessResult(ProcessResultType type, IEnumerable<Exception> exceptions = null,
            string resultReference = null, bool logExcetions = true)
        {
            Type = type;
            ExecuteCommonConstruction(exceptions, resultReference, logExcetions);
            ExtractProcessResultTypeFromException();
        }

        /// <summary>
        ///     Type is defaulted to ProcessResultType.MultiStatus
        /// </summary>
        /// <param name="exceptions"></param>
        /// <param name="resultReference"></param>
        /// <param name="logExcetions"></param>
        public ProcessResult(IEnumerable<Exception> exceptions, string resultReference = null,
            bool logExcetions = true)
        {
            ExecuteCommonConstruction(exceptions, resultReference, logExcetions);
            ExtractProcessResultTypeFromException();
        }

        /// <summary>
        ///     Type is defaulted to ProcessResultType.InternalServerError
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="resultReference"></param>
        /// <param name="logExcetions"></param>
        public ProcessResult(Exception exception, string resultReference = null, bool logExcetions = true)
            : this(ProcessResultType.InternalServerError, new List<Exception> {exception}, resultReference, logExcetions
            )
        {
            ExtractProcessResultTypeFromException();
        }

        public bool LogExcetions { get; set; }
        public ProcessResultType Type { get; set; }
        public ICollection<Exception> Exceptions { get; set; }
        public string Reason { get; set; }

        [IgnoreDataMember]
        [JsonIgnore]
        public bool HasExceptions => Exceptions != null && Exceptions.Any();

        public string ResultReference { get; set; }

        private void ExecuteCommonConstruction(IEnumerable<Exception> exceptions, string resultReference,
            bool logExcetions)
        {
            LogExcetions = logExcetions;
            SetExceptions(exceptions);

            if (!string.IsNullOrWhiteSpace(resultReference))
            {
                ResultReference = resultReference.Trim();
                return;
            }

            ResultReference = Guid.NewGuid().ToString();
        }

        public ProcessResult WithReason(string reason)
        {
            Reason = reason;
            return this;
        }

        private void ExtractProcessResultTypeFromException(ICollection<Exception> exceptions = null)
        {
            exceptions = exceptions ?? Exceptions;

            if (exceptions == null || !exceptions.Any())
            {
                Type = ProcessResultType.Ok;
                return;
            }

            if (exceptions.Count > 1)
                Type = ProcessResultType.InternalServerError;

            var exception = exceptions.First();
            switch (exception)
            {
                case ForbiddenException _:
                    Reason = "Forbidden processes";
                    Type = ProcessResultType.Forbidden;
                    break;
                case ArgumentNullException _:
                case ArgumentException _:
                    Reason = "Bad requests";
                    Type = ProcessResultType.BadRequest;
                    break;
                case KeyNotFoundException _:
                case FileNotFoundException _:
                    Reason = "Expected object or key not found";
                    Type = ProcessResultType.NotFound;
                    break;
                case IOException _:
                    Reason = "Conflict";
                    Type = ProcessResultType.Conflict;
                    break;
                case NotImplementedException _:
                    Reason = "No matching process";
                    Type = ProcessResultType.NotImplemented;
                    break;
            }
        }

        public override string ToString()
        {
            if (!HasExceptions)
                return Type.IsSuccess ? Type.Name : base.ToString();

            if (Exceptions.Count == 1)
                return Exceptions.First().ToString();

            var aggregateException = new AggregateException(Exceptions);
            return aggregateException.ToString();
        }

        public static Exception ReplicateToGeneralException<TException>(TException source)
            where TException : Exception
        {
            if (source == null)
                return null;

            var destination = new Exception(source.ToString());
            return destination;
        }

        public ProcessResult DisableExceptionLogging()
        {
            LogExcetions = false;
            return this;
        }

        public ProcessResult EnableExceptionLogging()
        {
            LogExcetions = true;
            return this;
        }

        public ProcessResult ClearExceptions(IEnumerable<Exception> exceptions)
        {
            Exceptions = null;
            return this;
        }

        public ProcessResult SetExceptions(IEnumerable<Exception> exceptions)
        {
            Exceptions = exceptions?.Select(ReplicateToGeneralException).ToList();
            return this;
        }

        public ProcessResult SetException(Exception exception)
        {
            if (exception != null)
                SetExceptions(new List<Exception> {exception});
            return this;
        }

        public ProcessResult WithProcessResultType(ProcessResultType processResultType)
        {
            Type = processResultType;
            return this;
        }

        public static implicit operator ProcessResult(ProcessResultType type)
        {
            return new ProcessResult(type);
        }

        public bool Equals(ProcessResultType type)
        {
            return Type.Equals(type);
        }

        public static implicit operator ProcessResult(Exception exception)
        {
            return new ProcessResult(exception);
        }

        public static implicit operator ProcessResult(List<Exception> exceptions)
        {
            return new ProcessResult(exceptions);
        }

        public static implicit operator ProcessResult(HashSet<Exception> exceptions)
        {
            return new ProcessResult(exceptions);
        }

        public static implicit operator ProcessResult(Exception[] exceptions)
        {
            return new ProcessResult(exceptions);
        }

        public static implicit operator ProcessResult(ConcurrentBag<Exception> exceptions)
        {
            return new ProcessResult(exceptions);
        }

        //public void WriteExceptionsToLog(ILogger logger)
        //{
        //    if (!LogExcetions || !HasExceptions)
        //        return;

        //    if (Exceptions.Count == 1)
        //    {
        //        logger.LogException(Exceptions.First(), ResultReference);
        //    }
        //    else
        //    {
        //        var aggregateException = new AggregateException(Exceptions);
        //        logger.LogException(aggregateException, ResultReference);
        //    }
        //}
    }
}