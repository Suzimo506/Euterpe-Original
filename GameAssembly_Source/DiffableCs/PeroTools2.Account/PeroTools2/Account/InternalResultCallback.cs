namespace PeroTools2.Account;

internal class InternalResultCallback
{
	protected AccountCallback userCallback; //Field offset: 0x10

	public InternalResultCallback(AccountCallback callback) { }

	public override void OnCompleted() { }

	public override void OnFailed(int code, string msg) { }

	public override void OnStarted() { }

	public override void OnSucceed(string res) { }

}

