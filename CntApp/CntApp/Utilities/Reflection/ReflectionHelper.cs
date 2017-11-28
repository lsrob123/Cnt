using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CntApp.Utilities.Reflection
{
    public class ReflectionHelper
    {
        public List<string> ListAllEmbeddedResources()
        {
            var assembly = GetType().GetTypeInfo().Assembly;
            var names = assembly.GetManifestResourceNames().ToList();
            return names;
        }
    }
}