namespace Sirenix.Serialization;

internal sealed class CachedMemoryStream : ICacheNotificationReceiver
{
	public static int InitialCapacity; //Field offset: 0x0
	public static int MaxCapacity; //Field offset: 0x4
	private MemoryStream memoryStream; //Field offset: 0x10

	public MemoryStream MemoryStream
	{
		 get { } //Length: 194
	}

	private static CachedMemoryStream() { }

	public CachedMemoryStream() { }

	public static Cache<CachedMemoryStream> Claim(int minCapacity) { }

	public static Cache<CachedMemoryStream> Claim(Byte[] bytes = null) { }

	public MemoryStream get_MemoryStream() { }

	public override void OnClaimed() { }

	public override void OnFreed() { }

}

