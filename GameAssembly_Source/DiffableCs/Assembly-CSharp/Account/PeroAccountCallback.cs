namespace Account;

public class PeroAccountCallback : AccountCallback
{

	public PeroAccountCallback() { }

	public virtual void OnCompleted() { }

	public virtual void OnFailed(int code, string msg) { }

	public virtual void OnStarted() { }

	public virtual void OnSucceed(string res) { }

}

