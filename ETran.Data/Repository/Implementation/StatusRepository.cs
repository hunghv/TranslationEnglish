using ETran.Data.Common;
using ETran.Data.Entities;
using ETran.Data.Repository.Base;
using ETran.Data.Repository.Interfaces;

namespace ETran.Data.Repository.Implementation
{
   public class StatusRepository:EntityBaseRepository<Status>,IStatusRepository
    {
        public StatusRepository(ETranslationContext context) : base(context)
        {
        }
    }
}
