namespace Sirenix.Serialization;

public sealed class MultiDimensionalArrayFormatter : BaseFormatter<TArray>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public IDataReader reader; //Field offset: 0x0
		public string name; //Field offset: 0x0

		public <>c__DisplayClass6_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_1
	{
		public int elements; //Field offset: 0x0
		public long length; //Field offset: 0x0
		public <>c__DisplayClass6_0<TArray, TElement> CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass6_1() { }

		internal TElement <DeserializeImplementation>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public IDataWriter writer; //Field offset: 0x0

		public <>c__DisplayClass7_0() { }

		internal void <SerializeImplementation>b__0(TElement v) { }

	}

	private const string RANKS_NAME = "ranks"; //Field offset: 0x0
	private const char RANKS_SEPARATOR = '\u7C'; //Field offset: 0x0
	private static readonly int ArrayRank; //Field offset: 0x0
	private static readonly Serializer<TElement> ValueReaderWriter; //Field offset: 0x0

	private static MultiDimensionalArrayFormatter`2() { }

	public MultiDimensionalArrayFormatter`2() { }

	protected virtual void DeserializeImplementation(ref TArray value, IDataReader reader) { }

	protected virtual TArray GetUninitializedObject() { }

	private void IterateArrayRead(Array a, Action<TElement> read) { }

	private void IterateArrayRead(Array a, int rank, Int32[] indices, Action<TElement> read) { }

	private void IterateArrayWrite(Array a, Func<TElement> write) { }

	private void IterateArrayWrite(Array a, int rank, Int32[] indices, Func<TElement> write) { }

	protected virtual void SerializeImplementation(ref TArray value, IDataWriter writer) { }

}

