namespace NVorbis;

public class NewStreamEventArgs : EventArgs
{
	[CompilerGenerated]
	private IPacketProvider <PacketProvider>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IgnoreStream>k__BackingField; //Field offset: 0x18

	public bool IgnoreStream
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private IPacketProvider PacketProvider
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public NewStreamEventArgs(IPacketProvider packetProvider) { }

	[CompilerGenerated]
	public bool get_IgnoreStream() { }

	[CompilerGenerated]
	public IPacketProvider get_PacketProvider() { }

	[CompilerGenerated]
	public void set_IgnoreStream(bool value) { }

	[CompilerGenerated]
	private void set_PacketProvider(IPacketProvider value) { }

}

