using Microsoft.AspNetCore.Identity;
using MyVet.Web.Entities;
using System.Threading.Tasks;
//Todas las interfaces comienzan con I por standar

namespace MyVet.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}

