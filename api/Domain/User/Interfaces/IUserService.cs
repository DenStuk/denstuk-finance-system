using System.Threading.Tasks;
using api.Entities;

namespace api.Interfaces
{
    public interface IUserService
    {
        Task<User> GetProfile();
        Task UpdateProfile(User user);
        Task SetAvatar(string url);
    }
}