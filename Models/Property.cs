using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Findpropertymain.Models
{
    public partial class Property
    {
        public Property()
        {
            InterestedCustomers = new HashSet<InterestedCustomer>();
        }

        public short PropertyId { get; set; }

        [Required(ErrorMessage = "Enter Property Name")]
        [StringLength(60, MinimumLength = 4)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations

        public string PropertyName { get; set; }

        [Required(ErrorMessage = "Enter Bhk Type")]
        //[RegularExpression("[^0-9]", ErrorMessage = "BHK Type must be numeric")]  // validations
        public string BhkType { get; set; }

        [Required(ErrorMessage = "Enter Floor Number ")]
        //[RegularExpression("[^0-9]", ErrorMessage = "Floor number must be numeric")]   // validations
        public string FloorNo { get; set; }

        [Required(ErrorMessage = "Enter Total Floor Number ")]
        //[RegularExpression("[^0-9]", ErrorMessage = " Total Floor number must be numeric")]
        public string TotalFloorNo { get; set; }

        [Required(ErrorMessage = "Enter Age ")]
        //[RegularExpression("[^0-9]", ErrorMessage = "Age must be numeric")]
        public short PropertyAge { get; set; }

        [Required(ErrorMessage = "Enter Property Facing")]
        [StringLength(60, MinimumLength = 2)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations
        public string PropertyFacing { get; set; }

        [Required(ErrorMessage = "Enter city")]
        [StringLength(60, MinimumLength = 3)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations

        public string City { get; set; }

        [Required(ErrorMessage = "Enter Locality")]
        [StringLength(60, MinimumLength = 3)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations
        public string Locality { get; set; }

        [Required(ErrorMessage = "Enter Street Area")]
        [StringLength(60, MinimumLength = 4)]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]  // validations
        public string StreetArea { get; set; }
        [Required(ErrorMessage = "Enter Property Price")]
        //[RegularExpression("[^0-9]", ErrorMessage = "Price must be numeric")]  // validations
        public long? PropertyPrice { get; set; }
        public string Images { get; set; }
        public short? PropTypeId { get; set; }
        [Required(ErrorMessage = "Enter Owner Id")]
        [RegularExpression("[^0-9]", ErrorMessage = "Owner Id must be numeric")]
        public short? OwnerId { get; set; }

        public virtual User Owner { get; set; }
        public virtual PropertyType PropType { get; set; }
        public virtual ICollection<InterestedCustomer> InterestedCustomers { get; set; }
    }
}
