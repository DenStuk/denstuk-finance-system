using api.Data;
using api.Service;
using api.Entities;
using api.Repository;
using api.Interfaces;
using System.Threading.Tasks;

namespace api.Services
{
    public class UserService : ServiceFacade<User>, IUserService
    {
        public UserService(DataContext context, BaseRepository<User> repository) : base(context, repository) { }

        public Task<User> GetProfile()
        {
            throw new System.NotImplementedException();
        }

        public Task SetAvatar(string url)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateProfile(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}