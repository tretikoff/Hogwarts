package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("SignUp.SignUpApplication, Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", md5aa70c602e5237eb5ff9f8e805f11ae76.SignUpApplication.class, md5aa70c602e5237eb5ff9f8e805f11ae76.SignUpApplication.__md_methods);
		mono.android.Runtime.register ("Qoden.UI.QodenApplication, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", md51f9551d2a7722221dfa5a6ca7672b7eb.QodenApplication.class, md51f9551d2a7722221dfa5a6ca7672b7eb.QodenApplication.__md_methods);
		
	}
}
