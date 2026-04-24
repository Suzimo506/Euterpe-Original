namespace NexPlugin;

public class VSocket
{
	internal enum Result
	{
		Success = 0,
		Error = 1,
		WouldBlock = 2,
		PacketBufferFull = 3,
	}

	public const uint MAX_DATA_SIZE = 1250; //Field offset: 0x0
	public const uint MARGIN_SIZE = 12; //Field offset: 0x0
	public const uint DEFAULT_MAX_RECV_PACKTES = 128; //Field offset: 0x0
	public const uint TOTAL_NAT_TRAVERSAL_TIMEOUT_MS = 120000; //Field offset: 0x0

	public VSocket() { }

}

