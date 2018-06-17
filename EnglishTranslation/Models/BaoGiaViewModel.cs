using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace EnglishTranslation.Models
{
    public class BaoGiaViewModel
    {
        [DisplayName("Họ Tên")]
        public string Name { get; set; }
        [DisplayName("Địa chỉ mail")]
        public string Email { get; set; }
        [DisplayName("Điện thoại")]
        public string Phone { get; set; }
        [DisplayName("Quốc gia")]
        public string CountryValue { get; set; }
        public IEnumerable<SelectListItem> Country { get; set; }
        [DisplayName("Ngôn ngữ nguồn")]
        public string SourceValue { get; set; }
        public IEnumerable<SelectListItem> Source { get; set; }
        [DisplayName("Ngôn ngữ đích")]
        public string DestinationValue { get; set; }
        public IEnumerable<SelectListItem> Destination { get; set; }
        [DisplayName("Dịch vụ")]
        public string ServiceValue { get; set; }
        public IEnumerable<SelectListItem> Service { get; set; }
        [DisplayName("Dịch vụ khác")]
        public string OtherService { get; set; }
        [DisplayName("Đơn vị thành toán")]
        public string UnitPayValue { get; set; }
        public IEnumerable<SelectListItem> UnitPay { get; set; }
        [DisplayName("Phương thức thanh toán")]
        public string MethodPayValue { get; set; }
        public IEnumerable<SelectListItem> MethodPay { get; set; }
        
    }
}