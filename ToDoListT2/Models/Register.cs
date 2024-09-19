
namespace Models
{
    public class RegisterBodyRequest
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }

    public class RegisterBodyResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
