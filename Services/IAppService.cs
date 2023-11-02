using ChampagneMaui.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal interface IAppService
    {
        public Task<string> Login(LoginModel loginModel);
        public Task<(bool IsSuccess, string ErrorMessage)> SignUp(SignUpModel signUpModel);
    }
}
