
namespace Dating_App.Data
{
    public class Profile : Account
    {

        public string Firstname { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public DateTime? Age { get; set; }

        public int isDeleted = 0;
    }
}
