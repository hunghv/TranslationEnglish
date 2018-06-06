using ETran.Data.Common;
using ETran.Data.Entities;
using ETran.Data.Repository.Base;
using ETran.Data.Repository.Interfaces;

namespace ETran.Data.Repository.Implementation
{
    public class CoverImagesRepository : EntityBaseRepository<CoverImage>, ICoverImagesRepository
    {
        public CoverImagesRepository(ETranslationContext context) : base(context) { }
    }
}
