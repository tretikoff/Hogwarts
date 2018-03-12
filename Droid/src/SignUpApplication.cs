using System;
using Android.App;
using Android.Runtime;
using Qoden.UI;

namespace SignUp
{
    [Application]
    public class SignUpApplication : QodenApplication
    {
        public SignUpApplication(IntPtr handle, JniHandleOwnership transer) : base(handle, transer)
        {
        }
    }
}