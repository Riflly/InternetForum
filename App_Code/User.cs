using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public int PostCount { get; set; }
    public string Description { get; set; }
    public string ProfileImage { get; set; }
    public DateTime JoinDate { get; set; }

}