using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriftShop.Domain.Entity.Buyer
{
    public class Buyer
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber {  get; set; }    
        public string Email { get; set; }
        public string Password { get; set; }
        public bool isEmailVerified { get; set; }
        public bool isPhoneNumberVerified { get; set; }
        public List<BuyerAddress> BuyerAddresses {  get; set; }

    }
}
