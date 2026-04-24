namespace ProtoBuf.Meta;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class BasicList : IEnumerable
{
	public sealed class Group
	{
		public readonly int First; //Field offset: 0x10
		public readonly BasicList Items; //Field offset: 0x18

		public Group(int first) { }

	}

	public sealed class MatchPredicate : MulticastDelegate
	{

		public MatchPredicate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object value, object ctx, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(object value, object ctx) { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class Node
	{
		private readonly Object[] data; //Field offset: 0x10
		private int length; //Field offset: 0x18

		public object Item
		{
			 get { } //Length: 152
			 set { } //Length: 223
		}

		public int Length
		{
			 get { } //Length: 4
		}

		internal Node(Object[] data, int length) { }

		public Node Append(object value) { }

		internal void Clear() { }

		internal void CopyTo(Array array, int offset) { }

		public object get_Item(int index) { }

		public int get_Length() { }

		internal int IndexOf(MatchPredicate predicate, object ctx) { }

		internal int IndexOfReference(object instance) { }

		internal int IndexOfString(string value) { }

		public void RemoveLastWithMutate() { }

		public void set_Item(int index, object value) { }

		public Node Trim() { }

	}

	internal struct NodeEnumerator : IEnumerator
	{
		private int position; //Field offset: 0x0
		private readonly Node node; //Field offset: 0x8

		public override object Current
		{
			 get { } //Length: 35
		}

		internal NodeEnumerator(Node node) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private static readonly Node nil; //Field offset: 0x0
	protected Node head; //Field offset: 0x10

	public int Count
	{
		 get { } //Length: 26
	}

	public object Item
	{
		 get { } //Length: 30
	}

	private static BasicList() { }

	public BasicList() { }

	public int Add(object value) { }

	internal bool Contains(object value) { }

	public void CopyTo(Array array, int offset) { }

	public int get_Count() { }

	public object get_Item(int index) { }

	internal static BasicList GetContiguousGroups(Int32[] keys, Object[] values) { }

	public NodeEnumerator GetEnumerator() { }

	internal int IndexOf(MatchPredicate predicate, object ctx) { }

	internal int IndexOfReference(object instance) { }

	internal int IndexOfString(string value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Trim() { }

}

