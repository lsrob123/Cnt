using CntApp._DB;
using CntApp._Files;
using Xamarin.Forms;

namespace CntApp._StateStore
{
    public class LocalStateStore
    {
        private static readonly LocalDb LocalDb;

        static LocalStateStore()
        {
            LocalDb = new LocalDb(DependencyService.Get<IFilePathResolver>());
            Current = new LocalStateStore();
        }

        public static LocalStateStore Current { get; }

        public static void Start()
        {
        }
    }
}