using Domain.Enumerations;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LoginCredentials : IdentityUser
    {
        public LoginCredentials(string email, string cpf, string password, UserType userType)
        {
            Email = email;
            Cpf = cpf;
            Password = password;
            UserType = userType;
        }

        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Password { get; private set; }
        public UserType UserType { get; private set; }
        
    }
}
