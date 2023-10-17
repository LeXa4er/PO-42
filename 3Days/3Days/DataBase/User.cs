namespace _3Days.DataBase
{
    public class User
    {
        public UserType Type;

        public string Name;

        public User(UserType type, string name)
        {
            Type = type;
            Name = name;
        }

        public User() { }
    }

    public enum UserType
    {
        Admin,
        User
    }
}
