namespace ICSharpCode.SharpZipLib.Zip;

public class ZipEntry : ICloneable
{
	[Flags]
	private enum Known
	{
		None = 0,
		Size = 1,
		CompressedSize = 2,
		Crc = 4,
		Time = 8,
		ExternalAttributes = 16,
	}

	internal int AESKeySize; //Field offset: 0x10
	private Known known; //Field offset: 0x14
	private int externalFileAttributes; //Field offset: 0x18
	private ushort versionMadeBy; //Field offset: 0x1C
	private string name; //Field offset: 0x20
	private ulong size; //Field offset: 0x28
	private ulong compressedSize; //Field offset: 0x30
	private ushort versionToExtract; //Field offset: 0x38
	private uint crc; //Field offset: 0x3C
	private uint dosTime; //Field offset: 0x40
	private CompressionMethod method; //Field offset: 0x44
	private Byte[] extra; //Field offset: 0x48
	private string comment; //Field offset: 0x50
	private int flags; //Field offset: 0x58
	private long zipFileIndex; //Field offset: 0x60
	private long offset; //Field offset: 0x68
	private bool forceZip64_; //Field offset: 0x70
	private byte cryptoCheckValue_; //Field offset: 0x71

	public bool CentralHeaderRequiresZip64
	{
		 get { } //Length: 90
	}

	public string Comment
	{
		 set { } //Length: 137
	}

	public long CompressedSize
	{
		 get { } //Length: 18
		 set { } //Length: 9
	}

	public CompressionMethod CompressionMethod
	{
		 get { } //Length: 4
	}

	public long Crc
	{
		 get { } //Length: 17
		 set { } //Length: 61
	}

	internal byte CryptoCheckValue
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	public DateTime DateTime
	{
		 set { } //Length: 244
	}

	public long DosTime
	{
		 set { } //Length: 8
	}

	public int ExternalFileAttributes
	{
		 get { } //Length: 16
		 set { } //Length: 8
	}

	public Byte[] ExtraData
	{
		 set { } //Length: 208
	}

	public int Flags
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int HostSystem
	{
		 get { } //Length: 5
	}

	public bool IsCrypted
	{
		 get { } //Length: 7
	}

	public bool IsDirectory
	{
		 get { } //Length: 148
	}

	public bool IsFile
	{
		 get { } //Length: 78
	}

	public bool LocalHeaderRequiresZip64
	{
		 get { } //Length: 70
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public long Offset
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	public long Size
	{
		 get { } //Length: 18
		 set { } //Length: 9
	}

	public int Version
	{
		 get { } //Length: 236
	}

	public long ZipFileIndex
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method) { }

	public static string CleanName(string name) { }

	public override object Clone() { }

	public bool get_CentralHeaderRequiresZip64() { }

	public long get_CompressedSize() { }

	public CompressionMethod get_CompressionMethod() { }

	public long get_Crc() { }

	internal byte get_CryptoCheckValue() { }

	public int get_ExternalFileAttributes() { }

	public int get_Flags() { }

	public int get_HostSystem() { }

	public bool get_IsCrypted() { }

	public bool get_IsDirectory() { }

	public bool get_IsFile() { }

	public bool get_LocalHeaderRequiresZip64() { }

	public string get_Name() { }

	public long get_Offset() { }

	public long get_Size() { }

	public int get_Version() { }

	public long get_ZipFileIndex() { }

	private bool HasDosAttributes(int attributes) { }

	public static bool IsCompressionMethodSupported(CompressionMethod method) { }

	public bool IsCompressionMethodSupported() { }

	private void ProcessAESExtraData(ZipExtraData extraData) { }

	internal void ProcessExtraData(bool localHeader) { }

	public void set_Comment(string value) { }

	public void set_CompressedSize(long value) { }

	public void set_Crc(long value) { }

	internal void set_CryptoCheckValue(byte value) { }

	public void set_DateTime(DateTime value) { }

	public void set_DosTime(long value) { }

	public void set_ExternalFileAttributes(int value) { }

	public void set_ExtraData(Byte[] value) { }

	public void set_Flags(int value) { }

	public void set_Offset(long value) { }

	public void set_Size(long value) { }

	public void set_ZipFileIndex(long value) { }

	public virtual string ToString() { }

}

