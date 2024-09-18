namespace Models
{
    public class LoginBodyRequest
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class ResponseUser
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
    public class LoginBodyResponse
    {
        public ResponseUser user { get; set; }
        public string token { get; set; }
    }
}
