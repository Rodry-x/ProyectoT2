using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using System.Diagnostics;


namespace Helpers
{
    public class FetchHelper: IDisposable
    {
        private readonly HttpClient _client;
        private readonly string _apiBaseUrl;
        private string _authorizationToken;

        public FetchHelper()
        {
            _client = new HttpClient();
            _apiBaseUrl = "https://todo-api-1-giy3.onrender.com";
        }

        /// <summary>
        /// Sets a permanent authorization token to be used in all requests.
        /// </summary>
        /// <param name="token">The authorization token.</param>
        public void SetAuthorizationToken(string token)
        {
            _authorizationToken = token;
            if (!string.IsNullOrEmpty(_authorizationToken))
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authorizationToken);
            }
        }

        /// <summary>
        /// Removes the authorization token from the headers.
        /// </summary>
        public void RemoveAuthorizationToken()
        {
            _authorizationToken = null;
            _client.DefaultRequestHeaders.Authorization = null;
        }

        /// <summary>
        /// Sends a GET request to the specified URL and deserializes the JSON response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the response to.</typeparam>
        /// <param name="endpoint">The request endpoint.</param>
        /// <returns>The deserialized response.</returns>
        public async Task<T> GetAsync<T>(string endpoint)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                HttpResponseMessage response = await _client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                T data = JsonConvert.DeserializeObject<T>(jsonResponse);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in GET request: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Sends a POST request with JSON data to the specified URL and deserializes the JSON response to the specified type.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request data.</typeparam>
        /// <typeparam name="TResponse">The type to deserialize the response to.</typeparam>
        /// <param name="endpoint">The request endpoint.</param>
        /// <param name="data">The request data.</param>
        /// <returns>The deserialized response.</returns>
        public async Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                string jsonRequest = JsonConvert.SerializeObject(data);
                StringContent content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(url, content);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                TResponse responseData = JsonConvert.DeserializeObject<TResponse>(jsonResponse);

                return responseData;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in POST request: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Sends a PUT request with JSON data to the specified URL and deserializes the JSON response to the specified type.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request data.</typeparam>
        /// <typeparam name="TResponse">The type to deserialize the response to.</typeparam>
        /// <param name="endpoint">The request endpoint.</param>
        /// <param name="data">The request data.</param>
        /// <returns>The deserialized response.</returns>
        public async Task<bool> PutAsync(string endpoint, object data)
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

        /// <summary>
        /// Sends a DELETE request to the specified URL and deserializes the JSON response to the specified type.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the response to.</typeparam>
        /// <param name="endpoint">The request endpoint.</param>
        /// <returns>The deserialized response.</returns>
        public async Task<T> DeleteAsync<T>(string endpoint)
        {
            try
            {
                string url = $"{_apiBaseUrl}/{endpoint}";
                HttpResponseMessage response = await _client.DeleteAsync(url);

                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                T data = JsonConvert.DeserializeObject<T>(jsonResponse);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DELETE request: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Disposes the HttpClient instance.
        /// </summary>
        public void Dispose()
        {
            _client.Dispose();
        }
    }
}