using Application.Services;
using Domain.Entities;
using Domain.Enumerations;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationService
{
    public class UserRegistrationService : IUsertRegistrationService
    {
        private readonly UserManager<UserRegistration> _userManager;
        public UserRegistrationService(UserManager<UserRegistration> userManager)
        {
            _userManager = userManager;
        }
        public Task<IdentityResult> RegisterAsync(string name, string cpf, string email, string password, UserType userType)
        {
            var user = new UserRegistration(name, cpf, email, password, userType);
            var result = _userManager.CreateAsync(user, password);

            return result;
        }
    }
}
