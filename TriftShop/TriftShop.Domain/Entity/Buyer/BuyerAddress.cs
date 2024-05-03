using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriftShop.Domain.Entity.Buyer
{
    public class BuyerAddress
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AddresLine { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string FlatNumber { get; set; }
        public string Floor { get; set; }
        
        public Buyer Buyer { get; set; }
    }
}
