using System;

namespace DCTracker.Models
{
    public class DCUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("n");
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PasswordHash { get; set; }
    }
}
