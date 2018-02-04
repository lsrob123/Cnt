using Lx.Utilities.Xamarin.Messages;

namespace CntApp.Messages
{
    public class OpenDetailPageMessage : MessageBase<string>
    {
        public OpenDetailPageMessage(string detailPage) : base(detailPage)
        {
        }
    }
}