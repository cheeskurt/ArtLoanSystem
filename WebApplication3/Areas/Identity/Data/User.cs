using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApplication3.Models;

namespace WebApplication3.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class

public class User : IdentityUser
{
    public int SubjectID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [MaxLength(3)]
    public string TeacherCode { get; set; }

    public Subject Subjects { get; set; }
}

