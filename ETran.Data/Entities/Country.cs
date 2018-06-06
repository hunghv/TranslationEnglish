using System.ComponentModel.DataAnnotations;
using ETran.Data.Entities.Base;

namespace ETran.Data.Entities
{
    public class Country : Entity
    {
        [MaxLength(150)]
        public string CountryName { get; set; }
    }
}
