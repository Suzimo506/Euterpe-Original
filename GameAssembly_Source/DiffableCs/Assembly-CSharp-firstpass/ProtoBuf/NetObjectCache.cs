namespace ProtoBuf;

internal sealed class NetObjectCache
{
	private sealed class ReferenceComparer : IEqualityComparer<Object>
	{
		public static readonly ReferenceComparer Default; //Field offset: 0x2C927FC

		private static ReferenceComparer() { }

		private ReferenceComparer() { }

		private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

		private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	}

	internal const int Root = 0; //Field offset: 0x0
	private MutableList underlyingList; //Field offset: 0x10
	private object rootObject; //Field offset: 0x18
	private int trapStartIndex; //Field offset: 0x20
	private Dictionary<String, Int32> stringKeys; //Field offset: 0x28
	private Dictionary<Object, Int32> objectKeys; //Field offset: 0x30

	private MutableList List
	{
		private get { } //Length: 106
	}

	public NetObjectCache() { }

	internal int AddObjectKey(object value, out bool existing) { }

	internal void Clear() { }

	private MutableList get_List() { }

	internal object GetKeyedObject(int key) { }

	internal void RegisterTrappedObject(object value) { }

	internal void SetKeyedObject(int key, object value) { }

}

