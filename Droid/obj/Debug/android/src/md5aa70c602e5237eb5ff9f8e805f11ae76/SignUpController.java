package md5aa70c602e5237eb5ff9f8e805f11ae76;


public class SignUpController
	extends md51f9551d2a7722221dfa5a6ca7672b7eb.QodenController_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SignUp.SignUpController, Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SignUpController.class, __md_methods);
	}


	public SignUpController ()
	{
		super ();
		if (getClass () == SignUpController.class)
			mono.android.TypeManager.Activate ("SignUp.SignUpController, Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
