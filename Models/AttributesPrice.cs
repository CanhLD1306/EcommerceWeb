using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceWeb.Models
{
    public partial class AttributesPrice
    {
        public int AttributesPriceId { get; set; }
        public int? AtrributesId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public int Actice { get; set; }

        public virtual Attribute Atrributes { get; set; }
        public virtual Product Product { get; set; }
    }
}
