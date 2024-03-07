using Domain.Enumerations;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRegistration : IdentityUser
    {
        public UserRegistration(string name, string cpf, string email, string password, UserType userType)
        {
            Name = name;
            Cpf = cpf;
            Email = email;
            Password = password;
            UserType = userType;
        }

        public string Name { get; private set; }
        public string Cpf {  get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public UserType UserType { get; private set; }

    }
}
