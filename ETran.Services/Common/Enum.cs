using System.ComponentModel.DataAnnotations;

namespace ETran.Services.Common
{

    public enum SortOrder
    {
        [Display(Name = "asc")]
        Asc,
        [Display(Name = "desc")]
        Desc,
        [Display(Name = "none")]
        None
    }

}
