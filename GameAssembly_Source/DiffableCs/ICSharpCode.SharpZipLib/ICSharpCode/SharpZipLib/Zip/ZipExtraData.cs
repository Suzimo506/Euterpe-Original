namespace ICSharpCode.SharpZipLib.Zip;

public sealed class ZipExtraData : IDisposable
{
	private int _index; //Field offset: 0x10
	private int _readValueStart; //Field offset: 0x14
	private int _readValueLength; //Field offset: 0x18
	private MemoryStream _newEntry; //Field offset: 0x20
	private Byte[] _data; //Field offset: 0x28

	public int UnreadCount
	{
		 get { } //Length: 126
	}

	public int ValueLength
	{
		 get { } //Length: 4
	}

	public ZipExtraData(Byte[] data) { }

	public override void Dispose() { }

	public bool Find(int headerID) { }

	public int get_UnreadCount() { }

	public int get_ValueLength() { }

	public int ReadByte() { }

	private void ReadCheck(int length) { }

	public int ReadInt() { }

	public long ReadLong() { }

	public int ReadShort() { }

	private int ReadShortInternal() { }

	public void Skip(int amount) { }

}

