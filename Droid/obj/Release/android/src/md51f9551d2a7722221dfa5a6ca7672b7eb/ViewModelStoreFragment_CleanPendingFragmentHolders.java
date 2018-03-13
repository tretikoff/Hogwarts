package md51f9551d2a7722221dfa5a6ca7672b7eb;


public class ViewModelStoreFragment_CleanPendingFragmentHolders
	extends android.support.v4.app.FragmentManager.FragmentLifecycleCallbacks
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFragmentDestroyed:(Landroid/support/v4/app/FragmentManager;Landroid/support/v4/app/Fragment;)V:GetOnFragmentDestroyed_Landroid_support_v4_app_FragmentManager_Landroid_support_v4_app_Fragment_Handler\n" +
			"";
		mono.android.Runtime.register ("Qoden.UI.ViewModelStoreFragment+CleanPendingFragmentHolders, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ViewModelStoreFragment_CleanPendingFragmentHolders.class, __md_methods);
	}


	public ViewModelStoreFragment_CleanPendingFragmentHolders ()
	{
		super ();
		if (getClass () == ViewModelStoreFragment_CleanPendingFragmentHolders.class)
			mono.android.TypeManager.Activate ("Qoden.UI.ViewModelStoreFragment+CleanPendingFragmentHolders, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onFragmentDestroyed (android.support.v4.app.FragmentManager p0, android.support.v4.app.Fragment p1)
	{
		n_onFragmentDestroyed (p0, p1);
	}

	private native void n_onFragmentDestroyed (android.support.v4.app.FragmentManager p0, android.support.v4.app.Fragment p1);

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
