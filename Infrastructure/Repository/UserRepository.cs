using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context) 
        {
            _context = context;
        }
        public Task<UserRegistration> GetUserByEmailOrCpfAsync(string email, string cpf)
        {
            return _context.UserRegistrations.FirstOrDefaultAsync(u => u.Email == email || u.Cpf == cpf);
        }
    }
}
