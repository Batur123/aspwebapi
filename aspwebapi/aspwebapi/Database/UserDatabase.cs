namespace aspwebapi.Database
{
    public class UserDatabase
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public UserDatabase(int _Id, string _Username, string _Password, string _Email)
        {
            this.Id = _Id;
            this.Username = _Username;
            this.Password = _Password;
            this.Email = _Email;
        }



    }
}
