namespace Sirenix.Serialization;

public sealed class DelegateFormatter : BaseFormatter<T>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<Type, String> <>9__6_0; //Field offset: 0x0
		public static Func<Type, String> <>9__6_1; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <DeserializeImplementation>b__6_0(Type p) { }

		internal string <DeserializeImplementation>b__6_1(Type p) { }

	}

	private static readonly Serializer<Object> ObjectSerializer; //Field offset: 0x0
	private static readonly Serializer<String> StringSerializer; //Field offset: 0x0
	private static readonly Serializer<Type> TypeSerializer; //Field offset: 0x0
	private static readonly Serializer<Type[]> TypeArraySerializer; //Field offset: 0x0
	private static readonly Serializer<Delegate[]> DelegateArraySerializer; //Field offset: 0x0

	private static DelegateFormatter`1() { }

	public DelegateFormatter`1() { }

	protected virtual void DeserializeImplementation(ref T value, IDataReader reader) { }

	protected virtual T GetUninitializedObject() { }

	protected virtual void SerializeImplementation(ref T value, IDataWriter writer) { }

}

