using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Interface
{
    public interface IUserRepository
    {
        Task<User> GetuserAsync(int id, double latitude, double longitude, int distance, bool genders, int start_age, int end_age);
        Task<IReadOnlyList<User>> GetUsersAsync();
    }   
}