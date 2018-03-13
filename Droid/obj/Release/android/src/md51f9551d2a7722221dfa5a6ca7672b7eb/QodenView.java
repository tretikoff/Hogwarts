package md51f9551d2a7722221dfa5a6ca7672b7eb;


public class QodenView
	extends android.view.ViewGroup
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onLayout:(ZIIII)V:GetOnLayout_ZIIIIHandler\n" +
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_dispatchSaveInstanceState:(Landroid/util/SparseArray;)V:GetDispatchSaveInstanceState_Landroid_util_SparseArray_Handler\n" +
			"n_dispatchRestoreInstanceState:(Landroid/util/SparseArray;)V:GetDispatchRestoreInstanceState_Landroid_util_SparseArray_Handler\n" +
			"n_onSaveInstanceState:()Landroid/os/Parcelable;:GetOnSaveInstanceStateHandler\n" +
			"n_onRestoreInstanceState:(Landroid/os/Parcelable;)V:GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler\n" +
			"";
		mono.android.Runtime.register ("Qoden.UI.QodenView, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", QodenView.class, __md_methods);
	}


	public QodenView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == QodenView.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenView, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public QodenView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == QodenView.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenView, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public QodenView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == QodenView.class)
			mono.android.TypeManager.Activate ("Qoden.UI.QodenView, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onLayout (boolean p0, int p1, int p2, int p3, int p4)
	{
		n_onLayout (p0, p1, p2, p3, p4);
	}

	private native void n_onLayout (boolean p0, int p1, int p2, int p3, int p4);


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void dispatchSaveInstanceState (android.util.SparseArray p0)
	{
		n_dispatchSaveInstanceState (p0);
	}

	private native void n_dispatchSaveInstanceState (android.util.SparseArray p0);


	public void dispatchRestoreInstanceState (android.util.SparseArray p0)
	{
		n_dispatchRestoreInstanceState (p0);
	}

	private native void n_dispatchRestoreInstanceState (android.util.SparseArray p0);


	public android.os.Parcelable onSaveInstanceState ()
	{
		return n_onSaveInstanceState ();
	}

	private native android.os.Parcelable n_onSaveInstanceState ();


	public void onRestoreInstanceState (android.os.Parcelable p0)
	{
		n_onRestoreInstanceState (p0);
	}

	private native void n_onRestoreInstanceState (android.os.Parcelable p0);

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
