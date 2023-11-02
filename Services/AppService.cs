using MauiBlazorAppTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ThreadNetwork;
using System.Net.Http;
using System.Diagnostics;
using ChampagneMaui.Models.Account;

namespace ChampagneMaui.Services
{
    internal class AppService : IAppService
    {
        public async Task<string> Login(LoginModel loginModel)
        {
            string returnStr = string.Empty;

            var _baseUrl = new Uri("https://localhost:7171");

            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.Login}";

                var serializedStr = JsonConvert.SerializeObject(loginModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                returnStr = await response.Content.ReadAsStringAsync();

                //if (response.IsSuccessStatusCode)
                //{
                //    returnStr = await response.Content.ReadAsStringAsync(); 
                //}

                return returnStr;
            } 
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> SignUp(SignUpModel signUpModel)
        {
            string errorMessage = string.Empty;
            bool isSuccess = false;

            var _baseUrl = new Uri("https://localhost:7171");

            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.SignUp}";

                var serializedStr = JsonConvert.SerializeObject(signUpModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    isSuccess = true;
                }
                else
                {
                    errorMessage = await response.Content.ReadAsStringAsync();
                }

                return (isSuccess, errorMessage);
            }
        }

        public async Task<(bool IsSuccess, string ErrorMessage)> GetUser(SignUpModel signUpModel)
        {
            string errorMessage = string.Empty;
            bool isSuccess = false;

            var _baseUrl = new Uri("https://localhost:7171");

            using (var client = new HttpClient())
            {
                var url = $"{_baseUrl}{APIs.SignUp}";

                var serializedStr = JsonConvert.SerializeObject(signUpModel);

                var response = await client.PostAsync(url, new StringContent(serializedStr, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    isSuccess = true;
                }
                else
                {
                    errorMessage = await response.Content.ReadAsStringAsync();
                }

                return (isSuccess, errorMessage);
            }
        }

       



    }
}
