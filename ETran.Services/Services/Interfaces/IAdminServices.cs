using ETran.Services.ViewModels.Request;

namespace ETran.Services.Services.Interfaces
{
    public interface IAdminServices
    {
        int SaveContact(ContactViewModel model);
    }
}
