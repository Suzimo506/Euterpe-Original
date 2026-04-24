namespace System.Text.RegularExpressions;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CaptureCollection : ICollection, IEnumerable
{
	internal Group _group; //Field offset: 0x10
	internal int _capcount; //Field offset: 0x18
	internal Capture[] _captures; //Field offset: 0x20

	public override int Count
	{
		 get { } //Length: 4
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public Capture Item
	{
		 get { } //Length: 8
	}

	public override object SyncRoot
	{
		 get { } //Length: 5
	}

	internal CaptureCollection() { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override int get_Count() { }

	public override bool get_IsSynchronized() { }

	public Capture get_Item(int i) { }

	public override object get_SyncRoot() { }

	internal Capture GetCapture(int i) { }

	public override IEnumerator GetEnumerator() { }

}

