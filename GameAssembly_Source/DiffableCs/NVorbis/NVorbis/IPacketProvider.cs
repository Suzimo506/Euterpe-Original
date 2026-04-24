namespace NVorbis;

public interface IPacketProvider : IDisposable
{

	public event EventHandler<ParameterChangeEventArgs> ParameterChange
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public bool CanSeek
	{
		 get { } //Length: 0
	}

	public long ContainerBits
	{
		 get { } //Length: 0
	}

	public int StreamSerial
	{
		 get { } //Length: 0
	}

	public void add_ParameterChange(EventHandler<ParameterChangeEventArgs> value) { }

	public DataPacket FindPacket(long granulePos, Func<DataPacket, DataPacket, Int32> packetGranuleCountCallback) { }

	public bool get_CanSeek() { }

	public long get_ContainerBits() { }

	public int get_StreamSerial() { }

	public long GetGranuleCount() { }

	public DataPacket GetNextPacket() { }

	public DataPacket GetPacket(int packetIndex) { }

	public DataPacket PeekNextPacket() { }

	public void remove_ParameterChange(EventHandler<ParameterChangeEventArgs> value) { }

	public void SeekToPacket(DataPacket packet, int preRoll) { }

}

