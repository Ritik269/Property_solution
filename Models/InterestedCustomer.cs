using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Findpropertymain.Models
{
    public partial class InterestedCustomer
    {
        [Required(ErrorMessage = "Enter Customer Id ")]
        [RegularExpression("[^0-9]", ErrorMessage = "Customer Id must be numeric")]  // validations
        public short CustomerId { get; set; }
        [Required(ErrorMessage = "Enter Property Id ")]
        [RegularExpression("[^0-9]", ErrorMessage = "Property Id must be numeric")]  // validations
        public short PropertyId { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "EnterDate Of Intrest ")]                             // Validations

        public DateTime DateOfInterest { get; set; }

        public virtual User Customer { get; set; }
        public virtual Property Property { get; set; }
    }
}
