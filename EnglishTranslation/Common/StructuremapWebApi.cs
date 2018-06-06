using System.Web.Http;
using EnglishTranslation.Common;
using EnglishTranslation.DependencyResolution;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(StructuremapWebApi), "Start")]

namespace EnglishTranslation.Common
{
    public static class StructuremapWebApi
    {
        public static void Start()
        {
            var container = StructuremapMvc.StructureMapDependencyScope.Container;
            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
        }
    }
}