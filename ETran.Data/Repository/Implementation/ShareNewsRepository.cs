using ETran.Data.Common;
using ETran.Data.Entities;
using ETran.Data.Repository.Base;
using ETran.Data.Repository.Interfaces;

namespace ETran.Data.Repository.Implementation
{
    public class ShareNewsRepository:EntityBaseRepository<ShareNews>,IShareNewsRepository
    {
        public ShareNewsRepository(ETranslationContext context) : base(context)
        {
        }
    }
}
