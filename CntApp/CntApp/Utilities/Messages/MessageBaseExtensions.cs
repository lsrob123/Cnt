using Xamarin.Forms;

namespace CntApp.Utilities.Messages
{
    public static class ContentViewBaseExtensions
    {
        public static string GetTypeName<TMessage, TData>(this TMessage message) where TMessage : MessageBase<TData>
        {
            return message.GetType().Name;
        }

        //TODO: Review if really needed
        //public static void GetOpened<TMessage, TData>(this TMessage message, object sender)
        //    where TMessage : MessageBase<TData>
        //{
        //    MessagingCenter.Send(sender, message.GetTypeName<TMessage, TData>(), message);
        //}
    }
}