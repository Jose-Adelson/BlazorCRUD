namespace BlazorApp_ProjetoCSI.Services
{
    public class UserService
    {
        public string UserName { get; private set; } = "Usuário";

        public void SetUserName(string userName)
        {
            UserName = userName;
        }
    }
}
