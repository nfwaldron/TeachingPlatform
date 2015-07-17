using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string MemberType { get; set; }
        
    }
}