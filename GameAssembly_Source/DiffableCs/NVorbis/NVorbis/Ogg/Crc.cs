namespace NVorbis.Ogg;

internal class Crc
{
	private static UInt32[] crcTable; //Field offset: 0x0
	private uint _crc; //Field offset: 0x10

	private static Crc() { }

	public Crc() { }

	public void Reset() { }

	public bool Test(uint checkCrc) { }

	public void Update(int nextVal) { }

}

