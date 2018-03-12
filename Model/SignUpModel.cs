using System;
using Microsoft.Extensions.Logging;
using Qoden.Binding;

namespace SignUp
{
    public class SignUpModel : DataContext
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public Command SignUpCommand;

        public SignUpModel()
        {
            SignUpCommand = new Command()
            {
                Action = PerformSignUp,
                CanExecute = FieldsAreValid
            };
        }

        public bool FieldsAreValid(object arg) =>
            Login.Length >= 3 && Password.Equals(ConfirmPassword);
//            false;

        private void PerformSignUp(object obj)
        {
            //TODO: show alert or something
            System.Diagnostics.Debug.WriteLine("Signing Up !");
        }
    }
}