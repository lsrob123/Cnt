namespace Lx.Utilities.Xamarin.Messages
{
    public interface IMessageBase
    {
    }

    public interface IMessageBase<out TData> : IMessageBase
    {
        TData Data { get; }
    }
}