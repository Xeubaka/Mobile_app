package md551cea73b35a83c85b81cdc9f8706ac6d;


public class ItenFragment
	extends android.support.v4.app.ListFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onListItemClick:(Landroid/widget/ListView;Landroid/view/View;IJ)V:GetOnListItemClick_Landroid_widget_ListView_Landroid_view_View_IJHandler\n" +
			"";
		mono.android.Runtime.register ("App_standard.Droid.ItenFragment, App_standard.Droid", ItenFragment.class, __md_methods);
	}


	public ItenFragment ()
	{
		super ();
		if (getClass () == ItenFragment.class)
			mono.android.TypeManager.Activate ("App_standard.Droid.ItenFragment, App_standard.Droid", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onListItemClick (android.widget.ListView p0, android.view.View p1, int p2, long p3)
	{
		n_onListItemClick (p0, p1, p2, p3);
	}

	private native void n_onListItemClick (android.widget.ListView p0, android.view.View p1, int p2, long p3);

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
