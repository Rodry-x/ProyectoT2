namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class PutUserBodyRequest
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }

    public class PostUserBodyResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}