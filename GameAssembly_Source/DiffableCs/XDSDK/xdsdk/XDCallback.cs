namespace xdsdk;

public abstract class XDCallback
{

	protected XDCallback() { }

	public override void OnBindTaptapSucceed(Dictionary<String, String> msg) { }

	public abstract void OnExitCancel() { }

	public abstract void OnExitConfirm() { }

	public override void OnGuestBindFailed(string msg) { }

	public abstract void OnGuestBindSucceed(string token) { }

	public abstract void OnInitFailed(string msg) { }

	public abstract void OnInitSucceed() { }

	public abstract void OnLoginCanceled() { }

	public abstract void OnLoginFailed(string msg) { }

	public abstract void OnLoginSucceed(string token) { }

	public abstract void OnLogoutSucceed() { }

	public abstract void OnPayCanceled() { }

	public abstract void OnPayCompleted() { }

	public abstract void OnPayFailed(string msg) { }

	public override void OnProtocolAgreed() { }

	public override void OnProtocolOpenFailed(string msg) { }

	public override void OnProtocolOpenSucceed() { }

	public abstract void OnRealNameFailed(string msg) { }

	public abstract void OnRealNameSucceed() { }

	public override void OnWXShareFailed(string msg) { }

	public override void OnWXShareSucceed() { }

	public abstract void RestoredPayment(List<Dictionary`2<String, String>> resultList) { }

}

