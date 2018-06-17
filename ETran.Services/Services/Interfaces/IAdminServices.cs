using System.Collections.Generic;
using ETran.Data.Entities;
using ETran.Services.ViewModels.Request;

namespace ETran.Services.Services.Interfaces
{
    public interface IAdminServices
    {
        int SaveContact(ContactViewModel model);
        List<Country> GetCountry();
    }
}
