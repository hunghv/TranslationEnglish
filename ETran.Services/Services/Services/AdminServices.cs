using System;
using AutoMapper;
using ETran.Data.Entities;
using ETran.Data.Repository.Interfaces;
using ETran.Services.Common;
using ETran.Services.Services.Interfaces;
using ETran.Services.ViewModels.Request;

namespace ETran.Services.Services.Services
{
    public class AdminServices : PaggingHelper, IAdminServices
    {
        #region Declare Property

        private readonly IContactRepository _contactRepository;
        private readonly DateTime _dateTime= DateTime.Now;
        #endregion

        #region Constructure

        public AdminServices(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        #endregion

        #region Public Method 
        public int SaveContact(ContactViewModel model)
        {

            try
            {
                model.CreatedBy = Constants.GetUserId();
                model.CreatedDate = _dateTime;
                var entity = Mapper.Map<ContactViewModel, Contact> (model);
                _contactRepository.Add(entity);
                _contactRepository.Commit();
                return entity.Id;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        #endregion
    }
}
