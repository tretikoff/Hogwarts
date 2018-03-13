using Qoden.Binding;
using Qoden.UI;

namespace SignUp
{
    public class SignUpController : QodenController<SignUpView>
    {
        private SignUpModel _model;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _model = this.GetViewModelStore().Get(() => new SignUpModel());

//            var signUpCommandBinding = new CommandBinding
//            {
//                Command = _model.SignUpCommand,
//                Trigger = View.SignUp.ClickTarget()
//            };
//
//            void UpdateSourceAndCommand(IPropertyBinding binding, ChangeSource source)
//            {
//                binding.UpdateSource();
//                signUpCommandBinding.UpdateTarget();
//            }

            //BUG: button state is not updated
            Bindings.Command(_model.SignUpCommand)
                .To(View.SignUp.ClickTarget());

            Bindings.Property(_model, x => x.Login)
                .To(View.Login.TextProperty())
                .AfterTargetUpdate((binding, source) => binding.UpdateSource());


            Bindings.Property(_model, x => x.Password)
                .To(View.Password.TextProperty())
                .AfterTargetUpdate((binding, source) => binding.UpdateSource());

            Bindings.Property(_model, x => x.ConfirmPassword)
                .To(View.ConfirmPassword.TextProperty())
                .AfterTargetUpdate((binding, source) => binding.UpdateSource());

        }
    }
}