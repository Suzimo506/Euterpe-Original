namespace ProtoBuf.Serializers;

internal sealed class ArrayDecorator : ProtoDecoratorBase
{
	private const byte OPTIONS_WritePacked = 1; //Field offset: 0x0
	private const byte OPTIONS_OverwriteList = 2; //Field offset: 0x0
	private const byte OPTIONS_SupportNull = 4; //Field offset: 0x0
	private readonly int fieldNumber; //Field offset: 0x18
	private readonly byte options; //Field offset: 0x1C
	private readonly WireType packedWireType; //Field offset: 0x20
	private readonly Type arrayType; //Field offset: 0x28
	private readonly Type itemType; //Field offset: 0x30

	private bool AppendToCollection
	{
		private get { } //Length: 11
	}

	public virtual Type ExpectedType
	{
		 get { } //Length: 5
	}

	public virtual bool RequiresOldValue
	{
		 get { } //Length: 11
	}

	public virtual bool ReturnsValue
	{
		 get { } //Length: 3
	}

	private bool SupportNull
	{
		private get { } //Length: 8
	}

	public ArrayDecorator(TypeModel model, IProtoSerializer tail, int fieldNumber, bool writePacked, WireType packedWireType, Type arrayType, bool overwriteList, bool supportNull) { }

	private bool get_AppendToCollection() { }

	public virtual Type get_ExpectedType() { }

	public virtual bool get_RequiresOldValue() { }

	public virtual bool get_ReturnsValue() { }

	private bool get_SupportNull() { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

