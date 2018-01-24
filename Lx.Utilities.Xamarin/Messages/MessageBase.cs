namespace Lx.Utilities.Xamarin.Messages
{
    public abstract class MessageBase<TData> : IMessageBase<TData>
    {
        protected MessageBase(TData message)
        {
            Data = message;
        }

        public TData Data { get; protected set; }
    }
}