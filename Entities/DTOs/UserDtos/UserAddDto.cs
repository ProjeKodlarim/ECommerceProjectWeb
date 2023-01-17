using Entities.Abstract;
using System;

namespace Entities.DTOs.UserDtos
{
    public class UserAddDto:IDto
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirtday { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}
