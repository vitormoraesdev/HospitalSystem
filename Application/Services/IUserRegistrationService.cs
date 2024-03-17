using Domain.Enumerations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUsertRegistrationService
    {
        Task<IdentityResult> RegisterAsync(string name,string cpf, string email, string password, UserType userType);
    }
}
