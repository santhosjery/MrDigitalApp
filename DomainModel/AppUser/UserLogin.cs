using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.AppUser
{
    public class UserLogin
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Mobile Number")]
        public string MobileNumber { get; set; }
    }
}
