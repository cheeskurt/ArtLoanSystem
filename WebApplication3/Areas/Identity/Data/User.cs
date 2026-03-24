using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication3.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class

public enum Class 
{ 

}

public class User : IdentityUser
{
    public int UserID { get; set; }
    public string AC { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Class Class { get; set; }
}

