namespace System.Net;

internal interface IWebConnectionState
{

	public WebConnectionGroup Group
	{
		 get { } //Length: 0
	}

	public WebConnectionGroup get_Group() { }

	public void SetIdle() { }

	public bool TrySetBusy() { }

}

