namespace NVorbis.Ogg;

internal class Packet : DataPacket
{
	private long _offset; //Field offset: 0x48
	private int _length; //Field offset: 0x50
	private int _curOfs; //Field offset: 0x54
	private Packet _mergedPacket; //Field offset: 0x58
	private Packet _next; //Field offset: 0x60
	private Packet _prev; //Field offset: 0x68
	private ContainerReader _containerReader; //Field offset: 0x70

	internal bool IsContinuation
	{
		internal get { } //Length: 10
		internal set { } //Length: 33
	}

	internal bool IsContinued
	{
		internal get { } //Length: 10
		internal set { } //Length: 33
	}

	internal Packet Next
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal Packet Prev
	{
		internal get { } //Length: 5
		internal set { } //Length: 12
	}

	internal Packet(ContainerReader containerReader, long streamOffset, int length) { }

	public virtual void Done() { }

	internal bool get_IsContinuation() { }

	internal bool get_IsContinued() { }

	internal Packet get_Next() { }

	internal Packet get_Prev() { }

	internal void MergeWith(DataPacket continuation) { }

	protected virtual int ReadNextByte() { }

	internal void Reset() { }

	internal void set_IsContinuation(bool value) { }

	internal void set_IsContinued(bool value) { }

	internal void set_Next(Packet value) { }

	internal void set_Prev(Packet value) { }

}

