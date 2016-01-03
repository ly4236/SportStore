using System.ComponentModel.DataAnnotations;

namespace SportsStore.Domain.Entities
{
    public class ShippingDetails
    {

        [Display(Name = "姓名")]
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Display(Name = "联系方式1")]
        [Required(ErrorMessage = "Please enter the first address line")]
        public string Line1 { get; set; }

        [Display(Name = "联系方式2")]
        public string Line2 { get; set; }

        [Display(Name = "联系方式3")]
        public string Line3 { get; set; }

        [Display(Name = "市/县")]
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }

        [Display(Name = "区域")]
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        [Display(Name = "邮政编码")]
        public string Zip { get; set; }
        [Display(Name = "国家")]
        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }
        
    }
}
