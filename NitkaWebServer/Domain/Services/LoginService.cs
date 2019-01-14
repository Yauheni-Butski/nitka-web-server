namespace Domain.Services
{
    public static class LoginService
    {
        public static bool ValidateLoginAndPassword(string login, string password)
        {
            //TODO. Check from DATABASE
            var result = login == "admin" && password == "admin";
            return result;
        }
    }
}
