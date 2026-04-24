namespace ProtoBuf.Meta;

public sealed class LockContentedEventArgs : EventArgs
{
	private readonly string ownerStackTrace; //Field offset: 0x10

	public string OwnerStackTrace
	{
		 get { } //Length: 5
	}

	internal LockContentedEventArgs(string ownerStackTrace) { }

	public string get_OwnerStackTrace() { }

}

