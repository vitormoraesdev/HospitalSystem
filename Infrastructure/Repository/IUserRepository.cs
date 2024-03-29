﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public interface IUserRepository
    {
        Task<UserRegistration> GetUserByEmailOrCpfAsync(string email, string cpf);
    }
}
