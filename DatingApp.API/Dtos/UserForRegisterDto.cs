using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
     
        public UserForRegisterDto(string userName, string password, string gender, string knownAs, DateTime dateOfBirth, string city, string country, DateTime created, DateTime lastActive) 
        {
            this.UserName = userName;
                this.Password = password;
                this.Gender = gender;
                this.KnownAs = knownAs;
                this.DateOfBirth = dateOfBirth;
                this.City = city;
                this.Country = country;
                this.Created = created;
                this.LastActive = lastActive;
               
        }
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 to 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}