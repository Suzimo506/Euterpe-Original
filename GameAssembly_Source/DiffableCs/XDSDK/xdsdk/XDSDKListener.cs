namespace xdsdk;

public class XDSDKListener : MonoBehaviour
{
	internal sealed class UniversalCallbackDelegate : MulticastDelegate
	{

		public UniversalCallbackDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int code, string msg, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int code, string msg) { }

	}

	private const int OnInitSucceedCode = 1; //Field offset: 0x0
	private const int OnProtocolAgreedCode = 100; //Field offset: 0x0
	private const int OnWXShareFailedCode = 16; //Field offset: 0x0
	private const int OnWXShareSucceedCode = 15; //Field offset: 0x0
	private const int OnExitCancelCode = 14; //Field offset: 0x0
	private const int OnExitConfirmCode = 13; //Field offset: 0x0
	private const int OnPayCanceledCode = 12; //Field offset: 0x0
	private const int OnPayFailedCode = 11; //Field offset: 0x0
	private const int OnProtocolOpenSucceedCode = 101; //Field offset: 0x0
	private const int OnPayCompletedCode = 10; //Field offset: 0x0
	private const int OnRealNameFailedCode = 8; //Field offset: 0x0
	private const int OnRealNameSucceedCode = 7; //Field offset: 0x0
	private const int OnGuestBindSucceedCode = 6; //Field offset: 0x0
	private const int OnLoginCanceledCode = 5; //Field offset: 0x0
	private const int OnLoginFailedCode = 4; //Field offset: 0x0
	private const int OnLoginSucceedCode = 3; //Field offset: 0x0
	private const int OnInitFailedCode = 2; //Field offset: 0x0
	private const int OnLogoutSucceedCode = 9; //Field offset: 0x0
	private const int OnProtocolOpenFailedCode = 102; //Field offset: 0x0

	public XDSDKListener() { }

	public void OnExitCancel() { }

	public void OnExitConfirm() { }

	public void OnGuestBindFailed(string msg) { }

	public void OnGuestBindSucceed(string token) { }

	public void OnInitFailed(string msg) { }

	public void OnInitSucceed() { }

	public void OnLoginCanceled() { }

	public void OnLoginFailed(string msg) { }

	public void OnLoginSucceed(string token) { }

	public void OnLogoutSucceed() { }

	public void OnPayCanceled() { }

	public void OnPayCompleted() { }

	public void OnPayFailed(string msg) { }

	public void OnProtocolAgreed() { }

	public void OnProtocolOpenFailed(string msg) { }

	public void OnProtocolOpenSucceed() { }

	public void OnRealNameFailed(string msg) { }

	public void OnRealNameFailed() { }

	public void OnRealNameSucceed() { }

	public void OnWXShareFailed(string msg) { }

	public void OnWXShareSucceed() { }

	public void RestoredPayment(string msg) { }

	private void Start() { }

	public static void UniversalCallback(int code, string msg) { }

}

