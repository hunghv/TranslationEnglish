using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly ICountryRepository _countryRepository;
        private readonly DateTime _dateTime= DateTime.Now;
        #endregion

        #region Constructure

        public AdminServices(IContactRepository contactRepository, ICountryRepository countryRepository)
        {
            _contactRepository = contactRepository;
            _countryRepository = countryRepository;
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
            catch (Exception)
            {
                return 0;
            }
        }

        public List<Country> GetCountry()
        {
            try
            {
                var query = _countryRepository.GetAllNoneDeleted().ToList();
                
                return query;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
    }
}
