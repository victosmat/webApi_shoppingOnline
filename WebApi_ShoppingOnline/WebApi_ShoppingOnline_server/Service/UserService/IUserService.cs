using WebApi_ShoppingOnline.Entity;

namespace WebApi_ShoppingOnline.Service.UserService
{
    public interface IUserService
    {
        List<User> GetUsers();
        string AddUser(User user);
        User UpdateUser(User user);
        int DeleteUser(int userID);
        User CheckUser(string username, string password);
        List<User> GetUserByKeyword(string userKeyword);
    }
}
