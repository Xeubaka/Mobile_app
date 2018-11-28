package md551cea73b35a83c85b81cdc9f8706ac6d;


public class ItenAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App_standard.Droid.ItenAdapterViewHolder, App_standard.Droid", ItenAdapterViewHolder.class, __md_methods);
	}


	public ItenAdapterViewHolder ()
	{
		super ();
		if (getClass () == ItenAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("App_standard.Droid.ItenAdapterViewHolder, App_standard.Droid", "", this, new java.lang.Object[] {  });
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
