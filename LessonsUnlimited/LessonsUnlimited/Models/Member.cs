using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonsUnlimited.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Remote("ValidateUserName", "MembersDB", ErrorMessage = "This username has been taken", HttpMethod = "Post")]
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        //Why can't I add these to the database??

        //public Address BillingAddress { get; set; }
        //public Address ShippingAddress { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage="Password Required!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Required(ErrorMessage = "Password Required!")]
        public string ConfirmPassword { get; set; }

        // WHAT DO I DO IF I WANT A PROPERTY, BUT I DONT WANT IT TO BE ASSIGNED WHEN THE USER IS CREATED????
        // I WANT TO BE ABLE TO SAY WHETHER THE MEMBER IS A TEACHER OR A STUDENT

        //public string MemberType { get; set; }

    }
}