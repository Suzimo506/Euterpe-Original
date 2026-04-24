namespace Google.Protobuf.Reflection;

public sealed class FieldOptions : IExtendableMessage<FieldOptions>, IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>, IBufferMessage
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x2C927BC

		private static <>c() { }

		public <>c() { }

		internal FieldOptions <.cctor>b__93_0() { }

	}

	[DebuggerNonUserCode]
	internal static class Types
	{
		internal enum CType
		{
			String = 0,
			Cord = 1,
			StringPiece = 2,
		}

		internal enum JSType
		{
			JsNormal = 0,
			JsString = 1,
			JsNumber = 2,
		}


	}

	private static readonly MessageParser<FieldOptions> _parser; //Field offset: 0x0
	private static readonly CType CtypeDefaultValue; //Field offset: 0x8
	private static readonly bool PackedDefaultValue; //Field offset: 0xC
	private static readonly JSType JstypeDefaultValue; //Field offset: 0x10
	private static readonly bool LazyDefaultValue; //Field offset: 0x14
	private static readonly bool DeprecatedDefaultValue; //Field offset: 0x15
	private static readonly bool WeakDefaultValue; //Field offset: 0x16
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; //Field offset: 0x18
	private UnknownFieldSet _unknownFields; //Field offset: 0x10
	internal ExtensionSet<FieldOptions> _extensions; //Field offset: 0x18
	private int _hasBits0; //Field offset: 0x20
	private CType ctype_; //Field offset: 0x24
	private bool packed_; //Field offset: 0x28
	private JSType jstype_; //Field offset: 0x2C
	private bool lazy_; //Field offset: 0x30
	private bool deprecated_; //Field offset: 0x31
	private bool weak_; //Field offset: 0x32
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; //Field offset: 0x38

	[DebuggerNonUserCode]
	public CType Ctype
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool Deprecated
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		 get { } //Length: 191
	}

	[DebuggerNonUserCode]
	public bool HasCtype
	{
		 get { } //Length: 7
	}

	[DebuggerNonUserCode]
	public bool HasDeprecated
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasJstype
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasLazy
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasPacked
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool HasWeak
	{
		 get { } //Length: 8
	}

	[DebuggerNonUserCode]
	public JSType Jstype
	{
		 get { } //Length: 107
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool Lazy
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public bool Packed
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	[DebuggerNonUserCode]
	public static MessageParser<FieldOptions> Parser
	{
		 get { } //Length: 86
	}

	[DebuggerNonUserCode]
	private override MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
	{
		private get { } //Length: 248
	}

	[DebuggerNonUserCode]
	public bool Weak
	{
		 get { } //Length: 109
		 set { } //Length: 8
	}

	private static FieldOptions() { }

	[DebuggerNonUserCode]
	public FieldOptions() { }

	[DebuggerNonUserCode]
	public FieldOptions(FieldOptions other) { }

	[DebuggerNonUserCode]
	public override int CalculateSize() { }

	[DebuggerNonUserCode]
	public override FieldOptions Clone() { }

	[DebuggerNonUserCode]
	public override bool Equals(FieldOptions other) { }

	[DebuggerNonUserCode]
	public virtual bool Equals(object other) { }

	public CType get_Ctype() { }

	public bool get_Deprecated() { }

	public static MessageDescriptor get_Descriptor() { }

	public bool get_HasCtype() { }

	public bool get_HasDeprecated() { }

	public bool get_HasJstype() { }

	public bool get_HasLazy() { }

	public bool get_HasPacked() { }

	public bool get_HasWeak() { }

	public JSType get_Jstype() { }

	public bool get_Lazy() { }

	public bool get_Packed() { }

	public static MessageParser<FieldOptions> get_Parser() { }

	public bool get_Weak() { }

	[DebuggerNonUserCode]
	public virtual int GetHashCode() { }

	[DebuggerNonUserCode]
	public override void MergeFrom(FieldOptions other) { }

	[DebuggerNonUserCode]
	public override void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	[DebuggerNonUserCode]
	private override void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	private override MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	public void set_Ctype(CType value) { }

	public void set_Deprecated(bool value) { }

	public void set_Jstype(JSType value) { }

	public void set_Lazy(bool value) { }

	public void set_Packed(bool value) { }

	public void set_Weak(bool value) { }

	[DebuggerNonUserCode]
	public virtual string ToString() { }

	[DebuggerNonUserCode]
	public override void WriteTo(CodedOutputStream output) { }

}

