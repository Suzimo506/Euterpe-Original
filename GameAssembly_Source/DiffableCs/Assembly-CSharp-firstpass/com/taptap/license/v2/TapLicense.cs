namespace com.taptap.license.v2;

public class TapLicense
{
	internal sealed class DLCEventHandler : MulticastDelegate
	{

		public DLCEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(DLCResult result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(DLCResult result) { }

	}

	internal sealed class LicenseEventHandler : MulticastDelegate
	{

		public LicenseEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private static TapLicense singleton; //Field offset: 0x0
	private static object syncRoot; //Field offset: 0x8
	private bool inited; //Field offset: 0x10
	private LicenseEventHandler licenseHandler; //Field offset: 0x18
	private DLCEventHandler dlcHandler; //Field offset: 0x20

	public static TapLicense INSTANCE
	{
		 get { } //Length: 365
	}

	private static TapLicense() { }

	public TapLicense() { }

	public void checkLicense() { }

	public void checkLicense(LicenseEventHandler handler) { }

	public static TapLicense get_INSTANCE() { }

	public void initDLCManager(DLCEventHandler handler) { }

	public void initDLCManager(DLCEventHandler handler, bool checkOnce, string publicKey) { }

	public void onDLCCallback(DLCResult result) { }

	public void onLicenseSuccess() { }

	public void purchaseDLC(string sku) { }

	public void queryDLC(string sku) { }

}

