using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace LessonsUnlimited_V1._2.Helpers
{
    // In a static class, all fields and methods must be static.

    public static class ClaimsHelper
    {
        // This ClaimsHelper class has a static method called CanEdit.
        public static bool CanEdit() 
        {
            // The HttpContext.Current. Gets or sets the HttpContext object for the current HTTP request.
            var user = HttpContext.Current.User.Identity as ClaimsIdentity;
            
            // If the user is not authenticated, return false.
            if (!user.IsAuthenticated)
            {
                return false;
            }
            // If the has the claim ("CanEdit", "true"), then the helper will return true.
            return user.HasClaim("CanEdit", "true");
        }



    }
}