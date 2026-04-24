namespace ProtoBuf.Serializers;

internal class ListDecorator : ProtoDecoratorBase
{
	private const byte OPTIONS_IsList = 1; //Field offset: 0x0
	private const byte OPTIONS_SuppressIList = 2; //Field offset: 0x0
	private const byte OPTIONS_WritePacked = 4; //Field offset: 0x0
	private const byte OPTIONS_ReturnList = 8; //Field offset: 0x0
	private const byte OPTIONS_OverwriteList = 16; //Field offset: 0x0
	private const byte OPTIONS_SupportNull = 32; //Field offset: 0x0
	private static readonly Type ienumeratorType; //Field offset: 0x0
	private static readonly Type ienumerableType; //Field offset: 0x8
	private readonly byte options; //Field offset: 0x18
	private readonly Type declaredType; //Field offset: 0x20
	private readonly Type concreteType; //Field offset: 0x28
	private readonly MethodInfo add; //Field offset: 0x30
	private readonly int fieldNumber; //Field offset: 0x38
	protected readonly WireType packedWireType; //Field offset: 0x3C

	protected bool AppendToCollection
	{
		 get { } //Length: 12
	}

	public virtual Type ExpectedType
	{
		 get { } //Length: 5
	}

	private bool IsList
	{
		private get { } //Length: 7
	}

	protected override bool RequireAdd
	{
		 get { } //Length: 3
	}

	public virtual bool RequiresOldValue
	{
		 get { } //Length: 12
	}

	private bool ReturnList
	{
		private get { } //Length: 8
	}

	public virtual bool ReturnsValue
	{
		 get { } //Length: 8
	}

	private bool SupportNull
	{
		private get { } //Length: 8
	}

	private bool SuppressIList
	{
		private get { } //Length: 8
	}

	private bool WritePacked
	{
		private get { } //Length: 8
	}

	private static ListDecorator() { }

	protected ListDecorator(TypeModel model, Type declaredType, Type concreteType, IProtoSerializer tail, int fieldNumber, bool writePacked, WireType packedWireType, bool returnList, bool overwriteList, bool supportNull) { }

	internal static bool CanPack(WireType wireType) { }

	internal static ListDecorator Create(TypeModel model, Type declaredType, Type concreteType, IProtoSerializer tail, int fieldNumber, bool writePacked, WireType packedWireType, bool returnList, bool overwriteList, bool supportNull) { }

	protected bool get_AppendToCollection() { }

	public virtual Type get_ExpectedType() { }

	private bool get_IsList() { }

	protected override bool get_RequireAdd() { }

	public virtual bool get_RequiresOldValue() { }

	private bool get_ReturnList() { }

	public virtual bool get_ReturnsValue() { }

	private bool get_SupportNull() { }

	private bool get_SuppressIList() { }

	private bool get_WritePacked() { }

	protected MethodInfo GetEnumeratorInfo(TypeModel model, out MethodInfo moveNext, out MethodInfo current) { }

	public virtual object Read(object value, ProtoReader source) { }

	public virtual void Write(object value, ProtoWriter dest) { }

}

