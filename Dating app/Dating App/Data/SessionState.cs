namespace Dating_App.Data
{
    public class SessionState : Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Firstname { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public bool isLoggedIn { get; set; }

        public DateTime? Age { get; set; }

        public int isDeleted { get; set; }

        
    }
}
