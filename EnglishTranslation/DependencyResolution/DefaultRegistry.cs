using ETran.Data.Common;
using ETran.Data.Repository.Implementation;
using ETran.Data.Repository.Interfaces;
using ETran.Services.Services.Interfaces;
using ETran.Services.Services.Services;
using StructureMap;

namespace EnglishTranslation.DependencyResolution
{
   public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            // Dependency Resolution inrect Interfaces with Responsitory
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            //DataContext

            For<ETranslationContext>().Use<ETranslationContext>();

            //Services
           For<IAdminServices>().Use<AdminServices>();
//            For<IUserProfileServices>().Use<UserProfileServices>();

            //Repository
            For<ICategoriesRepository>().Use<CategoriesRepository>();
            For<IAttachmentRepository>().Use<AttachmentRepository>();
            For<ICountryRepository>().Use<CountryRepository>();
            For<ICoverImagesRepository>().Use<CoverImagesRepository>();
            For<ILikeRepository>().Use<LikeRepository>();
            For<INewsCommentRepository>().Use<NewsCommentRepository>();
            For<INewsRepository>().Use<NewsRepository>();
            For<IRoleRepository>().Use<RoleRepository>();
            For<IShareNewsRepository>().Use<ShareNewsRepository>();
            For<IStatusRepository>().Use<StatusRepository>();
            For<IUserLoginHistoryRepository>().Use<UserLoginHistoryRepository>();
            For<IUserProfileRepository>().Use<UserProfileRepository>();
            For<IUserRoleRepository>().Use<UserRoleRepository>();
            For<IContactRepository>().Use<ContactRepository>();
        }

       
    }
}
