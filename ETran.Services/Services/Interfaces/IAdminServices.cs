using ETran.Services.Common;

namespace ETran.Services.Services.Interfaces
{
    interface IAdminServices
    {
        IPagedResults<string> GetCategories();
    }
}
