using System;

namespace DatingApp.API.Dtos
{
  public class UserForListDto
  {

    public int UserId { get; set; }
    public string username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string Gender { get; set; }

    public int Age { get; set; }
    public string PhotoUrl { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string KnownAs { get; set; }
    public DateTime Created { get; set; }
    public DateTime LastActive { get; set; }
    public string Introduction { get; set; }
    public string Interests { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

  }
}