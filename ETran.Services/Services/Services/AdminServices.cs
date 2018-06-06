using ETran.Data.Repository.Interfaces;
using ETran.Services.Common;
using ETran.Services.Services.Interfaces;

namespace ETran.Services.Services.Services
{
    public class AdminServices : PaggingHelper, IAdminServices
    {
        #region Declare Property

        private readonly ICategoriesRepository _categoriesRepository;
        private readonly ICountryRepository _countryRepository;

        #endregion

        #region Constructure

        public AdminServices(ICategoriesRepository categoriesRepository, ICountryRepository countryRepository)
        {
            _categoriesRepository = categoriesRepository;
            _countryRepository = countryRepository;
        }

        #endregion

        #region Public Method 
        public IPagedResults<string> GetCategories()
        {
//            var respone = new PagedResults<CategoriesResponse>();
//            var query = _categoriesRepository.GetAllNoneDeleted();
//            respone.Total = query.Count();
//            //sort  data
//            if (!string.IsNullOrEmpty(request?.SortField))
//            {
//                OrderBy(ref query, request);
//            }
//            else
//            {
//                query = query.OrderBy(x => x.Name);
//            }
//            //pagging data
//            if (request?.Skip != null && request.Take.HasValue)
//            {
//                Paging(ref query, request);
//            }
//            var result = Mapper.Map<List<Categories>, List<CategoriesResponse>>(query.ToList());
//            respone.Data = result;
//            return respone;
            return null;
        }
        #endregion
    }
}
