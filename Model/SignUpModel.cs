using Qoden.Binding;

namespace SignUp
{
    public class SignUpModel : DataContext
    {
        private string _login;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                SignUpCommand.RaiseCanExecuteChanged();
            }
        }

        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                SignUpCommand.RaiseCanExecuteChanged();
            }
        }

        private string _confirmPassword;

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                SignUpCommand.RaiseCanExecuteChanged();
            }
        }

        public readonly Command SignUpCommand;

        public SignUpModel()
        {
            SignUpCommand = new Command
            {
                Action = PerformSignUp,
                CanExecute = FieldsAreValid
            };
        }

        private bool FieldsAreValid(object arg) =>
            Login?.Length >= 3 && string.Equals(Password, ConfirmPassword) && Password?.Length >= 6;

        private void PerformSignUp(object obj)
        {
            //TODO: show alert or something
            System.Diagnostics.Debug.WriteLine("Signing Up !");
        }
    }
}