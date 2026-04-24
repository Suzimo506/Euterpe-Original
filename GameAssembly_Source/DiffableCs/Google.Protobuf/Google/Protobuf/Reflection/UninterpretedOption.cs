namespace Google.Protobuf.Reflection;

public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x69C60

		private static <>c() { }

		public <>c() { }

		internal UninterpretedOption <.cctor>b__83_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal sealed class NamePart : IMessage<NamePart>, IMessage, IEquatable<NamePart>, IDeepCloneable<NamePart>, IBufferMessage
		{
			[CompilerGenerated]
			private sealed class <>c
			{
				public static readonly <>c <>9; //Field offset: 0x2C927B4

				private static <>c() { }

				public <>c() { }

				internal NamePart <.cctor>b__41_0() { }

			}

			private static readonly MessageParser<NamePart> _parser; //Field offset: 0x0
			private static readonly string NamePart_DefaultValue; //Field offset: 0x8
			private static readonly bool IsExtensionDefaultValue; //Field offset: 0x10
			private UnknownFieldSet _unknownFields; //Field offset: 0x10
			private int _hasBits0; //Field offset: 0x18
			private string namePart_; //Field offset: 0x20
			private bool isExtension_; //Field offset: 0x28

			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				 get { } //Length: 108
			}

			[DebuggerNonUserCode]
			public bool HasIsExtension
			{
				 get { } //Length: 7
			}

			[DebuggerNonUserCode]
			public bool HasNamePart_
			{
				 get { } //Length: 9
			}

			[DebuggerNonUserCode]
			public bool IsExtension
			{
				 get { } //Length: 109
				 set { } //Length: 8
			}

			[DebuggerNonUserCode]
			public string NamePart_
			{
				 get { } //Length: 102
				 set { } //Length: 90
			}

			[DebuggerNonUserCode]
			public static MessageParser<NamePart> Parser
			{
				 get { } //Length: 86
			}

			[DebuggerNonUserCode]
			private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
			{
				private get { } //Length: 165
			}

			private static NamePart() { }

			[DebuggerNonUserCode]
			public NamePart() { }

			[DebuggerNonUserCode]
			public NamePart(NamePart other) { }

			[DebuggerNonUserCode]
			public override int CalculateSize() { }

			[DebuggerNonUserCode]
			public override NamePart Clone() { }

			[DebuggerNonUserCode]
			public override bool Equals(NamePart other) { }

			[DebuggerNonUserCode]
			public virtual bool Equals(object other) { }

			public static MessageDescriptor get_Descriptor() { }

			public bool get_HasIsExtension() { }

			public bool get_HasNamePart_() { }

			public bool get_IsExtension() { }

			public string get_NamePart_() { }

			public static MessageParser<NamePart> get_Parser() { }

			[DebuggerNonUserCode]
			public virtual int GetHashCode() { }

			[DebuggerNonUserCode]
			public override void MergeFrom(NamePart other) { }

			[DebuggerNonUserCode]
			public override void MergeFrom(CodedInputStream input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

			[DebuggerNonUserCode]
			private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

			private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

			public void set_IsExtension(bool value) { }

			public void set_NamePart_(string value) { }

			[DebuggerNonUserCode]
			public virtual string ToString() { }

			[DebuggerNonUserCode]
			public override void WriteTo(CodedOutputStream output) { }

		}


	}

	private static readonly MessageParser<UninterpretedOption> _parser; //Field offset: 0x0
	private static readonly FieldCodec<NamePart> _repeated_name_codec; //Field offset: 0x8
	private static readonly string IdentifierValueDefaultValue; //Field offset: 0x10
	private static readonly ulong PositiveIntValueDefaultValue; //Field offset: 0x18
	private static readonly long NegativeIntValueDefaultValue; //Field offset: 0x20
	private static readonly double DoubleValueDefaultValue; //Field offset: 0x28
	private static readonly ByteString StringValueDefaultValue; //Field offset: 0x30
	private static readonly string AggregateValueDefaultValue; //Field offset: 0x38
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	private int _hasBits0; //Field offset: 0x18
	private readonly RepeatedField<NamePart> name_; //Field offset: 0x20
	private string identifierValue_; //Field offset: 0x28
	private ulong positiveIntValue_; //Field offset: 0x30
	private long negativeIntValue_; //Field offset: 0x38
	private double doubleValue_; //Field offset: 0x40
	private ByteString stringValue_; //Field offset: 0x48
	private string aggregateValue_; //Field offset: 0x50

	[DebuggerNonUserCode]
	public string AggregateValue
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public double DoubleValue
	{
		 get { } //Length: 111
		 set { } //Length: 10
	}

	[DebuggerNonUserCode]
	public bool HasAggregateValue
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasDoubleValue
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasIdentifierValue
	{
		 get { } //Length: 9
	}

	[DebuggerNonUserCode]
	public bool HasNegativeIntValue
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasPositiveIntValue
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public bool HasStringValue
	{
		 get { } //Length: 88
	}

	[DebuggerNonUserCode]
	public string IdentifierValue
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	[DebuggerNonUserCode]
	public long NegativeIntValue
	{
		 get { } //Length: 109
		 set { } //Length: 9
	}

	[DebuggerNonUserCode]
	public static MessageParser<UninterpretedOption> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 72
	}

	[DebuggerNonUserCode]
	public ulong PositiveIntValue
	{
		 get { } //Length: 109
		 set { } //Length: 9
	}

	[DebuggerNonUserCode]
	public ByteString StringValue
	{
		 get { } //Length: 102
		 set { } //Length: 90
	}

	private static UninterpretedOption() { }

	[DebuggerNonUserCode]
	public UninterpretedOption() { }

	[DebuggerNonUserCode]
	public UninterpretedOption(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override UninterpretedOption Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public string get_AggregateValue() { }

	public static MessageDescriptor get_Descriptor() { }

	public double get_DoubleValue() { }

	public bool get_HasAggregateValue() { }

	public bool get_HasDoubleValue() { }

	public bool get_HasIdentifierValue() { }

	public bool get_HasNegativeIntValue() { }

	public bool get_HasPositiveIntValue() { }

	public bool get_HasStringValue() { }

	public string get_IdentifierValue() { }

	public long get_NegativeIntValue() { }

	public static MessageParser<UninterpretedOption> get_Parser() { }

	public ulong get_PositiveIntValue() { }

	public ByteString get_StringValue() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_AggregateValue(string value) { }

	public void set_DoubleValue(double value) { }

	public void set_IdentifierValue(string value) { }

	public void set_NegativeIntValue(long value) { }

	public void set_PositiveIntValue(ulong value) { }

	public void set_StringValue(ByteString value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

