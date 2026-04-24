namespace Pb;

public sealed class GameServerData : IMessage<GameServerData>, IMessage, IEquatable<GameServerData>, IDeepCloneable<GameServerData>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6ACC0

		private static <>c() { }

		public <>c() { }

		internal GameServerData <.cctor>b__42_0() { }

	}

	private static readonly MessageParser<GameServerData> _parser; //Field offset: 0x0
	public const int IsMinorFieldNumber = 1; //Field offset: 0x0
	public const int LoginTimeFieldNumber = 2; //Field offset: 0x0
	public const int AllTimeFieldNumber = 3; //Field offset: 0x0
	public const int IsStopFieldNumber = 4; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private bool isMinor_; //Field offset: 0x18
	private long loginTime_; //Field offset: 0x20
	private double allTime_; //Field offset: 0x28
	private bool isStop_; //Field offset: 0x30

	[DebuggerNonUserCode]
	public double AllTime
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public bool IsMinor
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public bool IsStop
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public long LoginTime
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	[DebuggerNonUserCode]
	public static MessageParser<GameServerData> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	private static GameServerData() { }

	[DebuggerNonUserCode]
	public GameServerData() { }

	[DebuggerNonUserCode]
	public GameServerData(GameServerData other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override GameServerData Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(GameServerData other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public double get_AllTime() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_IsMinor() { }

	public bool get_IsStop() { }

	public long get_LoginTime() { }

	public static MessageParser<GameServerData> get_Parser() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(GameServerData other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_AllTime(double value) { }

	public void set_IsMinor(bool value) { }

	public void set_IsStop(bool value) { }

	public void set_LoginTime(long value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

