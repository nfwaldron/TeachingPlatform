using MVCDropDownHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDropDownHelpers.Views.Products
{
    public class CreateVM
    {
        public SelectList Categories { get; set; } // SelecList is a specialized list used for working with dropdown menus.
        public Product Product { get; set; } //
    }
}