using System;
using Qoden.Binding;

namespace SignUp
{
    public class SignUpModel : DataContext
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        private Command SignUpCommand;

        public SignUpModel()
        {
            SignUpCommand = new Command()
            {
                Action = PerformSignUp,
                CanExecute = FieldsAreValid
            };
        }

        private bool FieldsAreValid(object arg) =>
            Login.Length >= 3 && Password.Equals(ConfirmPassword);

        private void PerformSignUp(object obj)
        {
            //TODO: show alert or something
        }
    }
}