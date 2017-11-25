using CntApp._DB;
using CntApp._Files;
using CntApp._StateStore;
using Xamarin.Forms;

namespace CntApp._Dependencies
{
    public static class DependencyRegistry
    {
        public static ILocalDb LocalDb { get; private set; }
        public static ILocalStateStore LocalStateStore { get; private set; }

        public static IFilePathResolver FilePathResolver => DependencyService.Get<IFilePathResolver>();

        public static void Init()
        {
            LocalDb = new LocalDb(FilePathResolver);
            LocalStateStore = new LocalStateStore(LocalDb);
        }
    }
}