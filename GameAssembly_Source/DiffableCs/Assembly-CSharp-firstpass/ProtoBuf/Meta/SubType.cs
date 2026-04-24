namespace ProtoBuf.Meta;

public sealed class SubType
{
	public sealed class Comparer : IComparer, IComparer<SubType>
	{
		public static readonly Comparer Default; //Field offset: 0x65140

		private static Comparer() { }

		public Comparer() { }

		public override int Compare(object x, object y) { }

		public override int Compare(SubType x, SubType y) { }

	}

	private readonly int fieldNumber; //Field offset: 0x10
	private readonly MetaType derivedType; //Field offset: 0x18
	private readonly DataFormat dataFormat; //Field offset: 0x20
	private IProtoSerializer serializer; //Field offset: 0x28

	public MetaType DerivedType
	{
		 get { } //Length: 5
	}

	public int FieldNumber
	{
		 get { } //Length: 4
	}

	internal IProtoSerializer Serializer
	{
		internal get { } //Length: 297
	}

	public SubType(int fieldNumber, MetaType derivedType, DataFormat format) { }

	private IProtoSerializer BuildSerializer() { }

	public MetaType get_DerivedType() { }

	public int get_FieldNumber() { }

	internal IProtoSerializer get_Serializer() { }

}

