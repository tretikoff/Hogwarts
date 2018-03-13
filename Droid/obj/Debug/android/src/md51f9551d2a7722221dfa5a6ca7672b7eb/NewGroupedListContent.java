package md51f9551d2a7722221dfa5a6ca7672b7eb;


public abstract class NewGroupedListContent
	extends android.widget.BaseExpandableListAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getChildType:(II)I:GetGetChildType_IIHandler\n" +
			"n_getChildTypeCount:()I:GetGetChildTypeCountHandler\n" +
			"n_getGroupType:(I)I:GetGetGroupType_IHandler\n" +
			"n_getGroupTypeCount:()I:GetGetGroupTypeCountHandler\n" +
			"n_getChildrenCount:(I)I:GetGetChildrenCount_IHandler\n" +
			"n_getGroupCount:()I:GetGetGroupCountHandler\n" +
			"n_getChildView:(IIZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetChildView_IIZLandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getGroupView:(IZLandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetGroupView_IZLandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getChildId:(II)J:GetGetChildId_IIHandler\n" +
			"n_isChildSelectable:(II)Z:GetIsChildSelectable_IIHandler\n" +
			"n_getGroupId:(I)J:GetGetGroupId_IHandler\n" +
			"n_hasStableIds:()Z:GetHasStableIdsHandler\n" +
			"n_getChild:(II)Ljava/lang/Object;:GetGetChild_IIHandler\n" +
			"n_getGroup:(I)Ljava/lang/Object;:GetGetGroup_IHandler\n" +
			"";
		mono.android.Runtime.register ("Qoden.UI.NewGroupedListContent, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NewGroupedListContent.class, __md_methods);
	}


	public NewGroupedListContent ()
	{
		super ();
		if (getClass () == NewGroupedListContent.class)
			mono.android.TypeManager.Activate ("Qoden.UI.NewGroupedListContent, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public int getChildType (int p0, int p1)
	{
		return n_getChildType (p0, p1);
	}

	private native int n_getChildType (int p0, int p1);


	public int getChildTypeCount ()
	{
		return n_getChildTypeCount ();
	}

	private native int n_getChildTypeCount ();


	public int getGroupType (int p0)
	{
		return n_getGroupType (p0);
	}

	private native int n_getGroupType (int p0);


	public int getGroupTypeCount ()
	{
		return n_getGroupTypeCount ();
	}

	private native int n_getGroupTypeCount ();


	public int getChildrenCount (int p0)
	{
		return n_getChildrenCount (p0);
	}

	private native int n_getChildrenCount (int p0);


	public int getGroupCount ()
	{
		return n_getGroupCount ();
	}

	private native int n_getGroupCount ();


	public android.view.View getChildView (int p0, int p1, boolean p2, android.view.View p3, android.view.ViewGroup p4)
	{
		return n_getChildView (p0, p1, p2, p3, p4);
	}

	private native android.view.View n_getChildView (int p0, int p1, boolean p2, android.view.View p3, android.view.ViewGroup p4);


	public android.view.View getGroupView (int p0, boolean p1, android.view.View p2, android.view.ViewGroup p3)
	{
		return n_getGroupView (p0, p1, p2, p3);
	}

	private native android.view.View n_getGroupView (int p0, boolean p1, android.view.View p2, android.view.ViewGroup p3);


	public long getChildId (int p0, int p1)
	{
		return n_getChildId (p0, p1);
	}

	private native long n_getChildId (int p0, int p1);


	public boolean isChildSelectable (int p0, int p1)
	{
		return n_isChildSelectable (p0, p1);
	}

	private native boolean n_isChildSelectable (int p0, int p1);


	public long getGroupId (int p0)
	{
		return n_getGroupId (p0);
	}

	private native long n_getGroupId (int p0);


	public boolean hasStableIds ()
	{
		return n_hasStableIds ();
	}

	private native boolean n_hasStableIds ();


	public java.lang.Object getChild (int p0, int p1)
	{
		return n_getChild (p0, p1);
	}

	private native java.lang.Object n_getChild (int p0, int p1);


	public java.lang.Object getGroup (int p0)
	{
		return n_getGroup (p0);
	}

	private native java.lang.Object n_getGroup (int p0);

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
