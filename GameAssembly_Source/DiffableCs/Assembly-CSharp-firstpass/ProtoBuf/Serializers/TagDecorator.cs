namespace ProtoBuf.Serializers;

internal sealed class TagDecorator : ProtoDecoratorBase, IProtoTypeSerializer, IProtoSerializer
{
	private readonly bool strict; //Field offset: 0x18
	private readonly int fieldNumber; //Field offset: 0x1C
	private readonly WireType wireType; //Field offset: 0x20

	public virtual Type ExpectedType
	{
		 get { } //Length: 69
	}

	private bool NeedsHint
	{
		private get { } //Length: 11
	}

	public virtual bool RequiresOldValue
	{
		 get { } //Length: 72
	}

	public virtual bool ReturnsValue
	{
		 get { } //Length: 72
	}

	public TagDecorator(int fieldNumber, WireType wireType, bool strict, IProtoSerializer tail) { }

	public override void Callback(object value, CallbackType callbackType, SerializationContext context) { }

	public override bool CanCreateInstance() { }

	public override object CreateInstance(ProtoReader source) { }

	public virtual Type get_ExpectedType() { }

	private bool get_NeedsHint() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	public override bool HasCallbacks(CallbackType callbackType) { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

