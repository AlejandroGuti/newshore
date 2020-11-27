using NewShore.Common.Enums;
using NewShore.Infrastructure.Entities;
using NewShore.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Infrastructure.Contexts
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserRepository _userRepository;

        public SeedDb(
           DataContext context,
           IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckRoles();
            await CheckUserAsync("115245684", "Ale", "Ale", "Alejandro@hotmail.com", UserType.Admin);
        }

        private async Task CheckRoles()
        {
            await _userRepository.CheckRoleAsync("Admin");
            await _userRepository.CheckRoleAsync("Customer");
        }

        private async Task<User> CheckUserAsync(
           string document,
           string firstName,
           string lastName,
           string email,
           UserType role)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    Document = document,
                    UserType= role
                };

                await _userRepository.AddUserAsync(user, "123456");
                await _userRepository.AddUserToRoleAsync(user, role.ToString());

                var token = await _userRepository.GenerateEmailConfirmationTokenAsync(user);
                await _userRepository.ConfirmEmailAsync(user, token);
            }

            return user;
        }

    }
}
