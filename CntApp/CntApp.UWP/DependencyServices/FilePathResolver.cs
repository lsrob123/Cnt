using CntApp.Domains.Files;

namespace CntApp.UWP.DependencyServices {
    public class FilePathResolver : FilePathResolverBase {
        public override string GetToolbarItemIconPath(string iconFileName) {
            return Compose("Assets/ToobarItemIcons/{0}", iconFileName);
        }
    }
}