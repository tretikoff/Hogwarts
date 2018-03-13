package md51f9551d2a7722221dfa5a6ca7672b7eb;


public abstract class PlainListContent
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getViewTypeCount:()I:GetGetViewTypeCountHandler\n" +
			"n_getItemViewType:(I)I:GetGetItemViewType_IHandler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_hasStableIds:()Z:GetHasStableIdsHandler\n" +
			"";
		mono.android.Runtime.register ("Qoden.UI.PlainListContent, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PlainListContent.class, __md_methods);
	}


	public PlainListContent ()
	{
		super ();
		if (getClass () == PlainListContent.class)
			mono.android.TypeManager.Activate ("Qoden.UI.PlainListContent, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);


	public int getViewTypeCount ()
	{
		return n_getViewTypeCount ();
	}

	private native int n_getViewTypeCount ();


	public int getItemViewType (int p0)
	{
		return n_getItemViewType (p0);
	}

	private native int n_getItemViewType (int p0);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public boolean hasStableIds ()
	{
		return n_hasStableIds ();
	}

	private native boolean n_hasStableIds ();

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
