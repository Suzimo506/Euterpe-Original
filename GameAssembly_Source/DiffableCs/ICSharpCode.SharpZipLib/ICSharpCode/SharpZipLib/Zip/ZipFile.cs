namespace ICSharpCode.SharpZipLib.Zip;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ZipFile : IDisposable, IEnumerable
{
	[Flags]
	private enum HeaderTest
	{
		Extract = 1,
		Header = 2,
	}

	internal sealed class KeysRequiredEventHandler : MulticastDelegate
	{

		public KeysRequiredEventHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(object sender, KeysRequiredEventArgs e, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(object sender, KeysRequiredEventArgs e) { }

	}

	private class PartialInputStream : Stream
	{
		private ZipFile zipFile_; //Field offset: 0x28
		private Stream baseStream_; //Field offset: 0x30
		private long start_; //Field offset: 0x38
		private long length_; //Field offset: 0x40
		private long readPos_; //Field offset: 0x48
		private long end_; //Field offset: 0x50

		public virtual bool CanRead
		{
			 get { } //Length: 3
		}

		public virtual bool CanSeek
		{
			 get { } //Length: 3
		}

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public virtual long Length
		{
			 get { } //Length: 5
		}

		public virtual long Position
		{
			 get { } //Length: 9
			 set { } //Length: 174
		}

		public PartialInputStream(ZipFile zipFile, long start, long length) { }

		public virtual void Close() { }

		public virtual void Flush() { }

		public virtual bool get_CanRead() { }

		public virtual bool get_CanSeek() { }

		public virtual bool get_CanWrite() { }

		public virtual long get_Length() { }

		public virtual long get_Position() { }

		public virtual int Read(Byte[] buffer, int offset, int count) { }

		public virtual int ReadByte() { }

		public virtual long Seek(long offset, SeekOrigin origin) { }

		public virtual void set_Position(long value) { }

		public virtual void SetLength(long value) { }

		public virtual void Write(Byte[] buffer, int offset, int count) { }

	}

	private class ZipEntryEnumerator : IEnumerator
	{
		private ZipEntry[] array; //Field offset: 0x10
		private int index; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 53
		}

		public ZipEntryEnumerator(ZipEntry[] entries) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	public KeysRequiredEventHandler KeysRequired; //Field offset: 0x10
	private bool isDisposed_; //Field offset: 0x18
	private string name_; //Field offset: 0x20
	private string comment_; //Field offset: 0x28
	private Stream baseStream_; //Field offset: 0x30
	private bool isStreamOwner; //Field offset: 0x38
	private long offsetOfFirstEntry; //Field offset: 0x40
	private ZipEntry[] entries_; //Field offset: 0x48
	private Byte[] key; //Field offset: 0x50
	private bool isNewArchive_; //Field offset: 0x58
	private UseZip64 useZip64_; //Field offset: 0x5C
	private ArrayList updates_; //Field offset: 0x60
	private Hashtable updateIndex_; //Field offset: 0x68
	private IArchiveStorage archiveStorage_; //Field offset: 0x70
	private IDynamicDataSource updateDataSource_; //Field offset: 0x78
	private int bufferSize_; //Field offset: 0x80
	private IEntryFactory updateEntryFactory_; //Field offset: 0x88

	private bool HaveKeys
	{
		private get { } //Length: 9
	}

	public bool IsStreamOwner
	{
		 get { } //Length: 5
	}

	public ZipFile(string name) { }

	public ZipFile(Stream stream) { }

	private static void CheckClassicPassword(CryptoStream classicCryptoStream, ZipEntry entry) { }

	public void Close() { }

	private Stream CreateAndInitDecryptionStream(Stream baseStream, ZipEntry entry) { }

	protected override void Dispose(bool disposing) { }

	private void DisposeInternal(bool disposing) { }

	protected virtual void Finalize() { }

	public int FindEntry(string name, bool ignoreCase) { }

	private bool get_HaveKeys() { }

	public bool get_IsStreamOwner() { }

	public ZipEntry GetEntry(string name) { }

	public override IEnumerator GetEnumerator() { }

	public Stream GetInputStream(long entryIndex) { }

	public Stream GetInputStream(ZipEntry entry) { }

	private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData) { }

	private long LocateEntry(ZipEntry entry) { }

	private void OnKeysRequired(string fileName) { }

	private void PostUpdateCleanup() { }

	private void ReadEntries() { }

	private uint ReadLEUint() { }

	private ulong ReadLEUlong() { }

	private ushort ReadLEUshort() { }

	private override void System.IDisposable.Dispose() { }

	private long TestLocalHeader(ZipEntry entry, HeaderTest tests) { }

}

