using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OdysejaAdmin.Data;
using OdysejaAdmin.Stores;

namespace OdysejaAdmin.Services
{
    public class AuthenticationService
    {
        private RestService _restService;
        private UserStore _userStore;

        public AuthenticationService(RestService restService, UserStore userStore)
        {
            _restService = restService;
            _userStore = userStore;
        }

        public async Task<bool> Authenticate(string userName, string password)
        {
            UserCredentials userCredentials = new UserCredentials(userName, password);
            HttpResponseMessage  response = await RestService.Post("/login", userCredentials);
            bool success = response.StatusCode == HttpStatusCode.OK;
            if (!success) return success;
            IEnumerable<string> cookies = response.Headers.SingleOrDefault(header => header.Key == "Set-Cookie").Value;
            _userStore.SetCookie(cookies.First().Split("=")[1]);
            return success;
        }

        public async void Logout()
        {
            await RestService.Post("/logout", null);
            _userStore.SetAuth(false);
        }
    }
}