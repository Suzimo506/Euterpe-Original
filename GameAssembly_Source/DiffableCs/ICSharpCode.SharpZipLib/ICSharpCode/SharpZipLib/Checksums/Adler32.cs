namespace ICSharpCode.SharpZipLib.Checksums;

public sealed class Adler32
{
	private uint checksum; //Field offset: 0x10

	public override long Value
	{
		 get { } //Length: 4
	}

	public Adler32() { }

	public override long get_Value() { }

	public override void Reset() { }

	public override void Update(Byte[] buffer, int offset, int count) { }

}

