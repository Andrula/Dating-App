namespace Dating_App.Data
{
    public class SessionState : Account
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Firstname { get; set; }
        public char Gender { get; set; }
        public string City { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public bool isLoggedIn { get; set; }

        //public bool isLoggedIn
        //{
        //    get
        //    {
        //        object o = ViewState["isLoggedIn"];
        //        if (o == null) return false;
        //        return (bool)o;
        //    }
        //    set
        //    {
        //        ViewState["isLoggedIn"] = value;
        //    }
        //}
        public DateTime? Age { get; set; }

        public int isDeleted = 0;

        
    }
}
