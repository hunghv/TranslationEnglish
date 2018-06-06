using ETran.Data.Common;
using ETran.Data.Entities;
using ETran.Data.Repository.Base;
using ETran.Data.Repository.Interfaces;

namespace ETran.Data.Repository.Implementation
{
    public class RoleRepository : EntityBaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(ETranslationContext context) : base(context)
        {
        }
    }
}
