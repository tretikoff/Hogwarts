package md51f9551d2a7722221dfa5a6ca7672b7eb;


public class FontIconDrawable
	extends android.graphics.drawable.Drawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOpacity:()I:GetGetOpacityHandler\n" +
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_isStateful:()Z:GetIsStatefulHandler\n" +
			"n_setState:([I)Z:GetSetState_arrayIHandler\n" +
			"n_setAlpha:(I)V:GetSetAlpha_IHandler\n" +
			"n_setColorFilter:(Landroid/graphics/ColorFilter;)V:GetSetColorFilter_Landroid_graphics_ColorFilter_Handler\n" +
			"n_clearColorFilter:()V:GetClearColorFilterHandler\n" +
			"";
		mono.android.Runtime.register ("Qoden.UI.FontIconDrawable, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", FontIconDrawable.class, __md_methods);
	}


	public FontIconDrawable ()
	{
		super ();
		if (getClass () == FontIconDrawable.class)
			mono.android.TypeManager.Activate ("Qoden.UI.FontIconDrawable, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public FontIconDrawable (java.lang.String p0, android.graphics.Typeface p1)
	{
		super ();
		if (getClass () == FontIconDrawable.class)
			mono.android.TypeManager.Activate ("Qoden.UI.FontIconDrawable, Qoden.UI.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:Android.Graphics.Typeface, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public int getOpacity ()
	{
		return n_getOpacity ();
	}

	private native int n_getOpacity ();


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);


	public boolean isStateful ()
	{
		return n_isStateful ();
	}

	private native boolean n_isStateful ();


	public boolean setState (int[] p0)
	{
		return n_setState (p0);
	}

	private native boolean n_setState (int[] p0);


	public void setAlpha (int p0)
	{
		n_setAlpha (p0);
	}

	private native void n_setAlpha (int p0);


	public void setColorFilter (android.graphics.ColorFilter p0)
	{
		n_setColorFilter (p0);
	}

	private native void n_setColorFilter (android.graphics.ColorFilter p0);


	public void clearColorFilter ()
	{
		n_clearColorFilter ();
	}

	private native void n_clearColorFilter ();

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
