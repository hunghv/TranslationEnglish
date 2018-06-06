using System.Web.Http.Dependencies;
using StructureMap;

namespace EnglishTranslation.DependencyResolution
{
    public class StructureMapWebApiDependencyScope : StructureMapDependencyScope, IDependencyScope
    {
        public StructureMapWebApiDependencyScope(IContainer container)
            : base(container)
        {
        }
    }
}
