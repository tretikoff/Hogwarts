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

//            Bindings.Property(_model, x => x.Login)
//                .To(View.Login.TextProperty());
        }
    }
}