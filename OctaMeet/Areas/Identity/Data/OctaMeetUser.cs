using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace OctaMeet.Areas.Identity.Data;

// Add profile data for application users by adding properties to the OctaMeetUser class
public class OctaMeetUser : IdentityUser
{
    public OctaMeetUser() : base()
    {
    }
    public OctaMeetUser(string userName) : base(userName)
    {
    }

    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }
    
    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(300)")]
    public string Surname { get; set; }
    
    [Required]
    [PersonalData]
    [Column(TypeName = "nvarchar(500)")]
    public string Phone {  get; set; }
}

