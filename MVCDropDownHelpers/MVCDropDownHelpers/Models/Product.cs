using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropDownHelpers.Models
{
    public class Product
    {
        // use the following in order to ensure that the correct value is entered
        [Remote("Validate Product Name", "Store", ErrorMessage="Product name taken", HttpMethod="post")]
        [Required(ErrorMessage="Name is Required")]
        public string Name { get; set; }
        public int Id { get; set; }
        public int CategoryId { get; set; }

        // Use to ensure that input is within the correct range
        [Range(0,1000, ErrorMessage = "Price is not Valid")]
        public decimal Price { get; set; }
        public Category Category { get; set; }

        Product()
        {
            this.Category = new Category();
        }
    }
}