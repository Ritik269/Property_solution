using System;
using System.Collections.Generic;

#nullable disable

namespace Findpropertymain.Models
{
    public partial class PropertyType
    {
        public PropertyType()
        {
            Properties = new HashSet<Property>();
        }

        public short PropTypeId { get; set; }
        public string TypeNmae { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
