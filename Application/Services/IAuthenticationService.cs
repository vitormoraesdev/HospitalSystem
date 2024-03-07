using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IAuthenticationService
    {
        bool VerifyPassword(string password, string hashedPassword);
        Task<string> AuthenticationAsync(string email, string cpf, string password);
    }
}
