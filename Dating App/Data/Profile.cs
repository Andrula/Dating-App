namespace Dating_App.Data
{
    public class Profile : Account
    {
        public string Firstname { get; set; }
        public char Gender { get; set; }
        public string City { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public DateTime? Age { get; set; }

        public int isDeleted = 0;
    }
}
