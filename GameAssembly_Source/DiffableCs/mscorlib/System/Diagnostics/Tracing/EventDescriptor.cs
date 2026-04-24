namespace System.Diagnostics.Tracing;

internal struct EventDescriptor
{
	private int m_traceloggingId; //Field offset: 0x0
	private ushort m_id; //Field offset: 0x0
	private byte m_version; //Field offset: 0x2
	private byte m_channel; //Field offset: 0x3
	private byte m_level; //Field offset: 0x4
	private byte m_opcode; //Field offset: 0x5
	private ushort m_task; //Field offset: 0x6
	private long m_keywords; //Field offset: 0x8

	public byte Channel
	{
		 get { } //Length: 5
	}

	public int EventId
	{
		 get { } //Length: 4
	}

	public long Keywords
	{
		 get { } //Length: 5
	}

	public byte Level
	{
		 get { } //Length: 5
	}

	public byte Opcode
	{
		 get { } //Length: 5
	}

	public int Task
	{
		 get { } //Length: 5
	}

	public byte Version
	{
		 get { } //Length: 5
	}

	public EventDescriptor(int traceloggingId, byte level, byte opcode, long keywords) { }

	public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords) { }

	public virtual bool Equals(object obj) { }

	public bool Equals(EventDescriptor other) { }

	public byte get_Channel() { }

	public int get_EventId() { }

	public long get_Keywords() { }

	public byte get_Level() { }

	public byte get_Opcode() { }

	public int get_Task() { }

	public byte get_Version() { }

	public virtual int GetHashCode() { }

}

