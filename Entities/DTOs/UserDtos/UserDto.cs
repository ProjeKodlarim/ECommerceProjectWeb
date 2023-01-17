using Entities.Abstract;
using System;

namespace Entities.DTOs.UserDtos
{
    public class UserDto:IDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirtday { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}
