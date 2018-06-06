using ETran.Data.Common;
using ETran.Data.Entities;
using ETran.Data.Repository.Base;
using ETran.Data.Repository.Interfaces;

namespace ETran.Data.Repository.Implementation
{
    public class UserRoleRepository: EntityBaseRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(ETranslationContext context) : base(context)
        {
        }
    }
}
