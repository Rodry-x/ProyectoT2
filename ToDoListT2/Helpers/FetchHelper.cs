using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Helpers
{
    public static class FetchHelper
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly string _apiBaseUrl = "https://todo-api-1-giy3.onrender.com";

        // Método para asegurarse de que el token JWT está configurado en el header
        public static void SetAuthenticationHeader(string token)
        {
            if (!string.IsNullOrEmpty(token) && _client.DefaultRequestHeaders.Authorization == null)
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public static void ClearAuthenticationHeader()
        {
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                HttpResponseMessage response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GET request: {ex.Message}", ex);
            }
        }

        public static async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                string jsonRequest = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in POST request: {ex.Message}", ex);
            }
        }

        public static async Task<bool> PutAsync(string endpoint, object data)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                string jsonRequest = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PutAsync(url, content);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in PUT request: {ex.Message}", ex);
            }
        }

        public static async Task<bool> DeleteAsync(string endpoint)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                HttpResponseMessage response = await _client.DeleteAsync(url);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DELETE request: {ex.Message}", ex);
            }
        }
    }
}
