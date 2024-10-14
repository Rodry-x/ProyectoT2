using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;
using Helpers;
using Models;

namespace Stores
{
    public abstract class UserStore
    {
        public static User User { get; set; } = new User();

        public static async Task register(string name, string email, string password)
        {
            AppHelper.SetLoading();
            try
            {
                var body = new RegisterBodyRequest
                {
                    name = name,
                    email = email,
                    password = password
                };
                await FetchHelper.PostAsync<RegisterBodyRequest, RegisterBodyResponse>("users", body);
                await login(email, password);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                AppHelper.RemoveLoading();
            }
        }

        public static async Task<bool> login(string email, string password)
        {
            AppHelper.SetLoading();
            try
            {
                var body = new LoginBodyRequest
                {
                    email = email,
                    password = password
                };
                var response = await FetchHelper.PostAsync<LoginBodyRequest, LoginBodyResponse>("auth/login", body);
                Debug.WriteLine($"Response user: {response.user}");
                User user = new User
                {
                    Id = response.user.id,
                    Name = response.user.name,
                    Email = response.user.email
                };
                User = user;
                FetchHelper.SetAuthenticationHeader(response.token);
                Debug.WriteLine($"Token: {response.token}");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                AppHelper.RemoveLoading();
            }
        }

        public static async Task<bool> editUser(string name, string email)
        {
            AppHelper.SetFloatingLoading();
            try
            {
                var body = new PutUserBodyRequest
                {
                    name = name,
                    email = email,
                };
                var success = await FetchHelper.PutAsync($"users/{User.Id}", body);
                User.Name = name;
                User.Email = email;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            finally
            {
                AppHelper.RemoveFloatingLoading();
            }
        }

        public static void Clear()
        {
            User = new User();
        }
    }
}