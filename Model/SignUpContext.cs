namespace SignUp
{
    public class SignUpContext
    {
        public static UserStorageService UserStorageService;

        public SignUpContext()
        {
            UserStorageService = new UserStorageService();
        }
    }
}