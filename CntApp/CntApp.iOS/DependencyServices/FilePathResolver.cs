using CntApp.Domains.Files;

namespace CntApp.iOS.DependencyServices {
    public class FilePathResolver : FilePathResolverBase {
        public override string GetToolbarItemIconPath(string iconFileName) {
            var path = Compose("{0}", iconFileName);
            return path;
        }
    }
}