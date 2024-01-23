namespace DDS.FireblocksApi.Models
{
    public class UserResponse
    {
        public UserResponse(string id, string firstName, string lastName, string role, string email, bool enabled)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Email = email;
            Enabled = enabled;
        }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Role { get; }

        public string Email { get; }

        public bool Enabled { get; }
    }
}
