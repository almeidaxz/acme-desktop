namespace ACME_Desk
{
    public class Login
    {
        public Login(string _email, string _password)
        {
            email = _email;
            password = _password;
        }

        public string email { get; set; }
        public string password { get; set; }
    }
}
