using Lx.Utilities.Xamarin.Messages;

namespace CntApp.Utilities.Messages
{
    public class OpenDetailPageMessage : MessageBase<string>
    {
        public OpenDetailPageMessage(string detailPage) : base(detailPage)
        {
        }
    }
}