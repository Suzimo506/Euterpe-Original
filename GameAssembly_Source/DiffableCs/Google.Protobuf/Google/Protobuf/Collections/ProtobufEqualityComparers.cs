namespace Google.Protobuf.Collections;

public static class ProtobufEqualityComparers
{
	private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<Double>
	{

		public BitwiseDoubleEqualityComparerImpl() { }

		public virtual bool Equals(double x, double y) { }

		public virtual int GetHashCode(double obj) { }

	}

	private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<Nullable`1<Double>>
	{

		public BitwiseNullableDoubleEqualityComparerImpl() { }

		public virtual bool Equals(Nullable<Double> x, Nullable<Double> y) { }

		public virtual int GetHashCode(Nullable<Double> obj) { }

	}

	private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<Nullable`1<Single>>
	{

		public BitwiseNullableSingleEqualityComparerImpl() { }

		public virtual bool Equals(Nullable<Single> x, Nullable<Single> y) { }

		public virtual int GetHashCode(Nullable<Single> obj) { }

	}

	private class BitwiseSingleEqualityComparerImpl : EqualityComparer<Single>
	{

		public BitwiseSingleEqualityComparerImpl() { }

		public virtual bool Equals(float x, float y) { }

		public virtual int GetHashCode(float obj) { }

	}

	[CompilerGenerated]
	private static readonly EqualityComparer<Double> <BitwiseDoubleEqualityComparer>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EqualityComparer<Single> <BitwiseSingleEqualityComparer>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly EqualityComparer<Nullable`1<Double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static readonly EqualityComparer<Nullable`1<Single>> <BitwiseNullableSingleEqualityComparer>k__BackingField; //Field offset: 0x18

	public static EqualityComparer<Double> BitwiseDoubleEqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 86
	}

	public static EqualityComparer<Nullable`1<Double>> BitwiseNullableDoubleEqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 87
	}

	public static EqualityComparer<Nullable`1<Single>> BitwiseNullableSingleEqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 87
	}

	public static EqualityComparer<Single> BitwiseSingleEqualityComparer
	{
		[CompilerGenerated]
		 get { } //Length: 87
	}

	private static ProtobufEqualityComparers() { }

	[CompilerGenerated]
	public static EqualityComparer<Double> get_BitwiseDoubleEqualityComparer() { }

	[CompilerGenerated]
	public static EqualityComparer<Nullable`1<Double>> get_BitwiseNullableDoubleEqualityComparer() { }

	[CompilerGenerated]
	public static EqualityComparer<Nullable`1<Single>> get_BitwiseNullableSingleEqualityComparer() { }

	[CompilerGenerated]
	public static EqualityComparer<Single> get_BitwiseSingleEqualityComparer() { }

	public static EqualityComparer<T> GetEqualityComparer() { }

}

