package md551cea73b35a83c85b81cdc9f8706ac6d;


public class ItenActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("App_standard.Droid.ItenActivity, App_standard.Droid", ItenActivity.class, __md_methods);
	}


	public ItenActivity ()
	{
		super ();
		if (getClass () == ItenActivity.class)
			mono.android.TypeManager.Activate ("App_standard.Droid.ItenActivity, App_standard.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
