using Application.Services;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        public AuthenticationService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);   
        }

        public async Task<string> AuthenticationAsync(string email, string cpf, string password)
        {
            var user = await _userRepository.GetUserByEmailOrCpfAsync(email, cpf);

            if(user != null && VerifyPassword(password, user.Password)) 
            {
                string token = GenerateJwtToken(user);
                return token;
            }
            return null;
        }

        
    }
}
