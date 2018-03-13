package md51f9551d2a7722221dfa5a6ca7672b7eb;


public class ChildViewControllersList_CleanupChildControllers
	extends android.support.v4.app.FragmentManager.FragmentLifecycleCallbacks
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFragmentDestroyed:(Landroid/support/v4/app/FragmentManager;Landroid/support/v4/app/Fragment;)V:GetOnFragmentDestroyed_Landroid_support_v4_app_FragmentManager_Landroid_support_v4_app_Fragment_Handler\n" +
			"n_onFragmentCreated:(Landroid/support/v4/app/FragmentManager;Landroid/support/v4/app/Fragment;Landroid/os/Bundle;)V:GetOnFragmentCreated_Landroid_support_v4_app_FragmentManager_Landroid_support_v4_app_Fragment_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Qoden.UI.ChildViewControllersList+CleanupChildControllers, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ChildViewControllersList_CleanupChildControllers.class, __md_methods);
	}


	public ChildViewControllersList_CleanupChildControllers ()
	{
		super ();
		if (getClass () == ChildViewControllersList_CleanupChildControllers.class)
			mono.android.TypeManager.Activate ("Qoden.UI.ChildViewControllersList+CleanupChildControllers, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFragmentDestroyed (android.support.v4.app.FragmentManager p0, android.support.v4.app.Fragment p1)
	{
		n_onFragmentDestroyed (p0, p1);
	}

	private native void n_onFragmentDestroyed (android.support.v4.app.FragmentManager p0, android.support.v4.app.Fragment p1);


	public void onFragmentCreated (android.support.v4.app.FragmentManager p0, android.support.v4.app.Fragment p1, android.os.Bundle p2)
	{
		n_onFragmentCreated (p0, p1, p2);
	}

	private native void n_onFragmentCreated (android.support.v4.app.FragmentManager p0, android.support.v4.app.Fragment p1, android.os.Bundle p2);

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
