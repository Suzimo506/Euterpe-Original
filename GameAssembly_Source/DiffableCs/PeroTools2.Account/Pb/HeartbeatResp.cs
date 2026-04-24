namespace Pb;

public sealed class HeartbeatResp : IMessage<HeartbeatResp>, IMessage, IEquatable<HeartbeatResp>, IDeepCloneable<HeartbeatResp>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927B4

		private static <>c() { }

		public <>c() { }

		internal HeartbeatResp <.cctor>b__42_0() { }

	}

	private static readonly MessageParser<HeartbeatResp> _parser; //Field offset: 0x0
	public const int MessageTypeFieldNumber = 1; //Field offset: 0x0
	public const int CodeFieldNumber = 2; //Field offset: 0x0
	public const int DataFieldNumber = 3; //Field offset: 0x0
	public const int ServerDataFieldNumber = 4; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private MessageType messageType_; //Field offset: 0x18
	private int code_; //Field offset: 0x1C
	private string data_; //Field offset: 0x20
	private GameServerData serverData_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public int Code
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public string Data
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public MessageType MessageType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public static MessageParser<HeartbeatResp> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public GameServerData ServerData
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	private static HeartbeatResp() { }

	[DebuggerNonUserCode]
	public HeartbeatResp() { }

	[DebuggerNonUserCode]
	public HeartbeatResp(HeartbeatResp other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override HeartbeatResp Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(HeartbeatResp other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public int get_Code() { }

	public string get_Data() { }

	public static MessageDescriptor get_Descriptor() { }

	public MessageType get_MessageType() { }

	public static MessageParser<HeartbeatResp> get_Parser() { }

	public GameServerData get_ServerData() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(HeartbeatResp other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Code(int value) { }

	public void set_Data(string value) { }

	public void set_MessageType(MessageType value) { }

	public void set_ServerData(GameServerData value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

