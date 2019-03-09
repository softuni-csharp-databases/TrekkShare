namespace TrekkShare.App.Core.Controller
{
    using Contracts;

    using TrekkShare.Services.Contracts;

    public class UserController : IController
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public string Create(string username, string password, string repeatPassword, string firstname, string lastname, string middleName, string email, string phone)
        {
            //validate input model

            //this.userService.Create("", "", "", "", "", "", "");

            return $"Successfully create {username}!";
        }
    }
}
