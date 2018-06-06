using AutoMapper;
using ETran.Data.Entities;
using ETran.Services.ViewModels.Request;

namespace ETran.Services.Mapping
{
    public class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Contact, ContactViewModel>();
                cfg.CreateMap<ContactViewModel, Contact>();
            });
        }
    }
}
