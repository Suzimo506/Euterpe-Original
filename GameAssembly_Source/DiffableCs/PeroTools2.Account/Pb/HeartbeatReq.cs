namespace Pb;

public sealed class HeartbeatReq : IMessage<HeartbeatReq>, IMessage, IEquatable<HeartbeatReq>, IDeepCloneable<HeartbeatReq>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x6ACBA

		private static <>c() { }

		public <>c() { }

		internal HeartbeatReq <.cctor>b__37_0() { }

	}

	private static readonly MessageParser<HeartbeatReq> _parser; //Field offset: 0x0
	public const int MessageTypeFieldNumber = 1; //Field offset: 0x0
	public const int TokenFieldNumber = 2; //Field offset: 0x0
	public const int GameIdFieldNumber = 3; //Field offset: 0x0
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private MessageType messageType_; //Field offset: 0x18
	private string token_; //Field offset: 0x20
	private GameIds gameId_; //Field offset: 0x28

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 188
	}

	[DebuggerNonUserCode]
	public GameIds GameId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public MessageType MessageType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[DebuggerNonUserCode]
	public static MessageParser<HeartbeatReq> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 245
	}

	[DebuggerNonUserCode]
	public string Token
	{
		 get { } //Length: 5
		 set { } //Length: 90
	}

	private static HeartbeatReq() { }

	[DebuggerNonUserCode]
	public HeartbeatReq() { }

	[DebuggerNonUserCode]
	public HeartbeatReq(HeartbeatReq other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override HeartbeatReq Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(HeartbeatReq other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public static MessageDescriptor get_Descriptor() { }

	public GameIds get_GameId() { }

	public MessageType get_MessageType() { }

	public static MessageParser<HeartbeatReq> get_Parser() { }

	public string get_Token() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(HeartbeatReq other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_GameId(GameIds value) { }

	public void set_MessageType(MessageType value) { }

	public void set_Token(string value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

