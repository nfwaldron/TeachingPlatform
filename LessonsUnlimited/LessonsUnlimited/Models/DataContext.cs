using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LessonsUnlimited.Models
{
    // Create Infrastructure to interact with database
    public class DataContext: DbContext
    {
        //Disable lazy loading by enabling the following.
        public DataContext ()
	    {
            this.Configuration.LazyLoadingEnabled = false;

	    }
       
        //Next Create the entities that we want to store in our database
        public IDbSet<Lesson> Lesson { get; set; }
        public IDbSet<Member> Member { get; set; }

    }
}