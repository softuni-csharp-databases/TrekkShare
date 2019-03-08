namespace TrekkShare.Services
{

    using System.Linq;
    using TrekkShare.Models;
    using TrekkShare.Services.Contracts;

    public class UserService : IUserService
    {
        public User Create(string username, 
            string password, 
            string firstName, 
            string middleName, 
            string lastName,
            string phone,
            string email)
        {
            throw new System.NotImplementedException();
        }

        public User Edit(string username, 
            string firstName, 
            string middleName,
            string lastName,
            string phone,
            string email)
        {
            throw new System.NotImplementedException();
        }

        public User Delete(string username)
        {
            throw new System.NotImplementedException();
        }

        public void ChangePassword(string username, 
            string oldPassword,
            string newPassword,
            string repeatedPassword)
        {
            throw new System.NotImplementedException();
        }

        public TModel ById<TModel>(string id)
        {
            throw new System.NotImplementedException();
        }

        public TModel ByUsername<TModel>(string username)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<TModel> All<TModel>()
        {
            throw new System.NotImplementedException();
        }
    }
}
