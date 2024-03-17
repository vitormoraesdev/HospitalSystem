﻿using Application.Services;
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
        private readonly UserRepository _userRepository;
        private readonly JwtService _jwtService;
        public AuthenticationService(UserRepository userRepository, JwtService jwtService) 
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
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
                string token = _jwtService.GenerateToken(user.Id);
                return token;
            }
            return null;
        }

        
    }
}
