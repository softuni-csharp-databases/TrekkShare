using System.ComponentModel;

namespace TrekkShare.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    public interface IUserService
    {
        User Create(string username, 
            string password, 
            string firstName, 
            string middleName, 
            string lastName,
            string phone,
            string email);

        User Edit(string username,
            string firstName,
            string middleName,
            string lastName,
            string phone,
            string email);

        User Delete(string username);

        void ChangePassword(string username,
            string oldPassword,
            string newPassword,
            string repeatedPassword
            );

        TModel ById<TModel>(string id);

        TModel ByUsername<TModel>(string username);

        IQueryable<TModel> All<TModel>();
    }
}
