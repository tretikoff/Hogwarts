package md51f9551d2a7722221dfa5a6ca7672b7eb;


public class QodenActivity_1
	extends md51f9551d2a7722221dfa5a6ca7672b7eb.QodenActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Qoden.UI.QodenActivity`1, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", QodenActivity_1.class, __md_methods);
	}


	public QodenActivity_1 ()
	{
		super ();
		if (getClass () == QodenActivity_1.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenActivity`1, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
