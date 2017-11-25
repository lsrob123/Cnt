using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CntApp.Utilities.Messages
{
 public abstract   class MessageBase<TData> : IMessageBase<TData>
    {
        protected MessageBase(TData message)
        {
            Data = message;
        }

        public TData Data { get; protected set; }

    }
}
