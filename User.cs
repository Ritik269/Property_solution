using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Findpropertymain.Models
{
    public partial class User
    {
        public User()
        {
            InterestedCustomers = new HashSet<InterestedCustomer>();
            Properties = new HashSet<Property>();
        }
        [Required(ErrorMessage = "Enter User Id ")]
        //[RegularExpression("[^0-9]", ErrorMessage = "User Id must be numeric")]  // validations
        public short UserId { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        [StringLength(60, MinimumLength = 4)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Mobile Number ")]
        //[RegularExpression("[^0-9]", ErrorMessage = "Mobile Number must be numeric")]  // validations

        public string UserMobileNumber { get; set; }

        [Required(ErrorMessage = "Enter your Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]

        public string UserEmailId { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [StringLength(60, MinimumLength = 4)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations
        public string UserPassword { get; set; }

        public short? TypeId { get; set; }

        public virtual UserType Type { get; set; }
        public virtual ICollection<InterestedCustomer> InterestedCustomers { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
