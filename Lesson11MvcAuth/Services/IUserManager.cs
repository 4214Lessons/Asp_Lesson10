using Lesson11MvcAuth.Models;

namespace Lesson11MvcAuth.Services
{
    public interface IUserManager
    {
        bool Register(string username, string password, bool isAdmin);
        bool Login(string username, string password);
        UserCredentials GetUserCredentials();
    }
}
