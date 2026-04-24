namespace Rewired.Utils.Classes.Data;

[CustomClassObfuscation]
[CustomObfuscation]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal sealed class RingBuffer : IEnumerable, IEnumerable<T>, ICollection<T>
{
	internal struct FBcaWbhtykbXFIxupuLQRBaMUuBj : IDisposable, IEnumerator, IEnumerator<>
	{
		private RingBuffer<> buffer; //Field offset: 0x0
		private int index; //Field offset: 0x0
		private int version; //Field offset: 0x0
		private  current; //Field offset: 0x0

		public override  Current
		{
			 get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 146
		}

		internal FBcaWbhtykbXFIxupuLQRBaMUuBj(RingBuffer<> unnamed_param_0) { }

		public override void Dispose() { }

		public override  get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private bool WaPswJerijpjNNfKccDDgkFnuRi() { }

	}

	private readonly T[] uasGypXPLEIXhSwoMRRmRLQEvhSE; //Field offset: 0x0
	private readonly int fHFzqBypypzEdxCsGjiRCvUHhtXo; //Field offset: 0x0
	private int bMhVYaaTyQYqscNkDurOnhRQhYUq; //Field offset: 0x0
	private int XusfyHcOJYCiLmKFewHsQFkPIFQcA; //Field offset: 0x0
	private int UhTGpTylKnMQSEByJFRyedFbvdqH; //Field offset: 0x0
	private int cpBcLSojANdtJHGYqEbpJswGxTYQ; //Field offset: 0x0
	private int GusbjnNWxeqFGJLFxSjFjcDCeenJ; //Field offset: 0x0
	private IEqualityComparer<T> hoHDrxdzKrmDOFcCcYazKFDZackZA; //Field offset: 0x0

	public int Capacity
	{
		 get { } //Length: 4
	}

	public int Count
	{
		 get { } //Length: 4
	}

	public IEqualityComparer<T> EqualityComparer
	{
		 get { } //Length: 5
		 set { } //Length: 56
	}

	public T Item
	{
		 get { } //Length: 209
		 set { } //Length: 236
	}

	public int OverrunCount
	{
		 get { } //Length: 4
	}

	private override int System.Collections.Generic.ICollection<T>.Count
	{
		private get { } //Length: 39
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	public RingBuffer`1(int unnamed_param_0) { }

	public void Clear() { }

	public bool Contains(T item) { }

	public bool Contains(T item, IEqualityComparer<T> comparer) { }

	private int CQjbLwHkNnDWwComyiWTrXDBznzH(int unnamed_param_0) { }

	public T Dequeue() { }

	public void Enqueue(T item) { }

	public bool EnqueueIfUnique(T item) { }

	public int get_Capacity() { }

	public int get_Count() { }

	public IEqualityComparer<T> get_EqualityComparer() { }

	public T get_Item(int index) { }

	public int get_OverrunCount() { }

	public int IndexOf(T item) { }

	public int IndexOf(T item, IEqualityComparer<T> comparer) { }

	private int IvWeMpYZUddvTpWYfTIqGJPOfLJP(T unnamed_param_0, IEqualityComparer<T> unnamed_param_1) { }

	private int IvWeMpYZUddvTpWYfTIqGJPOfLJP(T unnamed_param_0) { }

	private void mWscmAbDKCAvMUxXuadKdZJFysWS(int unnamed_param_0) { }

	public T Peek() { }

	public bool Remove(T item, IEqualityComparer<T> comparer) { }

	public bool Remove(T item) { }

	public int RemoveAll(T item) { }

	public int RemoveAll(T item, IEqualityComparer<T> comparer) { }

	public void RemoveAt(int index) { }

	public void set_EqualityComparer(IEqualityComparer<T> value) { }

	public void set_Item(int index, T value) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<T>.Clear() { }

	private override bool System.Collections.Generic.ICollection<T>.Contains(T unnamed_param_0) { }

	private override void System.Collections.Generic.ICollection<T>.CopyTo(T[] unnamed_param_0, int unnamed_param_1) { }

	private override int System.Collections.Generic.ICollection<T>.get_Count() { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override bool System.Collections.Generic.ICollection<T>.Remove(T unnamed_param_0) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private int VrVVxolQHDWZhgQeoRqbSPGNsyPu(int unnamed_param_0) { }

	private bool ywqKpruWYFpXuSKJkrXibuNHYhYl(int unnamed_param_0) { }

}

