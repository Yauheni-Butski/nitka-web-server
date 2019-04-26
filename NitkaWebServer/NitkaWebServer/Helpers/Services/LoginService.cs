namespace NitkaWebServer.Helpers.Services
{
    public static class LoginService
    {
        public static bool ValidateLoginAndPassword(string login, string password)
        {
            var result = login == "admin" && password == "admin";
            return result;
        }
    }
}
