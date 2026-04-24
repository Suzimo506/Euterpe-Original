namespace NAudio.Wave.Compression;

internal class AcmStreamHeaderStruct
{
	public int cbStruct; //Field offset: 0x10
	public AcmStreamHeaderStatusFlags fdwStatus; //Field offset: 0x14
	public IntPtr userData; //Field offset: 0x18
	public IntPtr sourceBufferPointer; //Field offset: 0x20
	public int sourceBufferLength; //Field offset: 0x28
	public int sourceBufferLengthUsed; //Field offset: 0x2C
	public IntPtr sourceUserData; //Field offset: 0x30
	public IntPtr destBufferPointer; //Field offset: 0x38
	public int destBufferLength; //Field offset: 0x40
	public int destBufferLengthUsed; //Field offset: 0x44
	public IntPtr destUserData; //Field offset: 0x48

	public AcmStreamHeaderStruct() { }

}

