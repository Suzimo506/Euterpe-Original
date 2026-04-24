namespace ProtoBuf.Serializers;

internal sealed class ImmutableCollectionDecorator : ListDecorator
{
	private readonly MethodInfo builderFactory; //Field offset: 0x40
	private readonly MethodInfo add; //Field offset: 0x48
	private readonly MethodInfo addRange; //Field offset: 0x50
	private readonly MethodInfo finish; //Field offset: 0x58

	protected virtual bool RequireAdd
	{
		 get { } //Length: 3
	}

	internal ImmutableCollectionDecorator(TypeModel model, Type declaredType, Type concreteType, IProtoSerializer tail, int fieldNumber, bool writePacked, WireType packedWireType, bool returnList, bool overwriteList, bool supportNull, MethodInfo builderFactory, MethodInfo add, MethodInfo addRange, MethodInfo finish) { }

	protected virtual bool get_RequireAdd() { }

	internal static bool IdentifyImmutable(TypeModel model, Type declaredType, out MethodInfo builderFactory, out MethodInfo add, out MethodInfo addRange, out MethodInfo finish) { }

	public virtual object Read(object value, ProtoReader source) { }

	private static Type ResolveIReadOnlyCollection(Type declaredType, Type t) { }

}

