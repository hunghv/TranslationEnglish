using ETran.Data.Common;
using ETran.Data.Entities;
using ETran.Data.Repository.Base;
using ETran.Data.Repository.Interfaces;

namespace ETran.Data.Repository.Implementation
{
    public class CountryRepository: EntityBaseRepository<Country>,ICountryRepository
    {
        public CountryRepository(ETranslationContext context) : base(context)
        {
        }
    }
}
