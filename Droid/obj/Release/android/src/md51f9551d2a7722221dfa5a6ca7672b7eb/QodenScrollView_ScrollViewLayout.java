package md51f9551d2a7722221dfa5a6ca7672b7eb;


public class QodenScrollView_ScrollViewLayout
	extends md51f9551d2a7722221dfa5a6ca7672b7eb.QodenView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Qoden.UI.QodenScrollView+ScrollViewLayout, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", QodenScrollView_ScrollViewLayout.class, __md_methods);
	}


	public QodenScrollView_ScrollViewLayout (android.content.Context p0)
	{
		super (p0);
		if (getClass () == QodenScrollView_ScrollViewLayout.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenScrollView+ScrollViewLayout, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public QodenScrollView_ScrollViewLayout (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == QodenScrollView_ScrollViewLayout.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenScrollView+ScrollViewLayout, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public QodenScrollView_ScrollViewLayout (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == QodenScrollView_ScrollViewLayout.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenScrollView+ScrollViewLayout, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
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
