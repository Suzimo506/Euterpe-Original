namespace NVorbis;

internal class StreamReadBuffer : IDisposable
{
	private class SavedBuffer
	{
		public Byte[] Buffer; //Field offset: 0x10
		public long BaseOffset; //Field offset: 0x18
		public int End; //Field offset: 0x20
		public int DiscardCount; //Field offset: 0x24
		public long VersionSaved; //Field offset: 0x28

		public SavedBuffer() { }

	}

	private class StreamWrapper
	{
		internal Stream Source; //Field offset: 0x10
		internal object LockObject; //Field offset: 0x18
		internal long EofOffset; //Field offset: 0x20
		internal int RefCount; //Field offset: 0x28

		public StreamWrapper() { }

	}

	private static Dictionary<Stream, StreamWrapper> _lockObjects; //Field offset: 0x0
	private StreamWrapper _wrapper; //Field offset: 0x10
	private int _maxSize; //Field offset: 0x18
	private Byte[] _data; //Field offset: 0x20
	private long _baseOffset; //Field offset: 0x28
	private int _end; //Field offset: 0x30
	private int _discardCount; //Field offset: 0x34
	private bool _minimalRead; //Field offset: 0x38
	private long _versionCounter; //Field offset: 0x40
	private List<SavedBuffer> _savedBuffers; //Field offset: 0x48

	public long BaseOffset
	{
		 get { } //Length: 9
	}

	internal long BufferEndOffset
	{
		internal get { } //Length: 77
	}

	public int MaxSize
	{
		 set { } //Length: 437
	}

	public bool MinimalRead
	{
		 set { } //Length: 4
	}

	private static StreamReadBuffer() { }

	internal StreamReadBuffer(Stream source, int initialSize, int maxSize, bool minimalRead) { }

	private void CalcBuffer(long offset, int count, out int readStart, out int readEnd) { }

	private void CommitDiscard() { }

	private void CreateNewBuffer(long offset, int count) { }

	public void DiscardThrough(long offset) { }

	public override void Dispose() { }

	private int EnsureAvailable(long offset, ref int count, bool isRecursion) { }

	private void EnsureBufferSize(int reqSize, bool copyContents, int copyOffset) { }

	private int FillBuffer(long offset, int count, int readStart, int readEnd) { }

	public long get_BaseOffset() { }

	internal long get_BufferEndOffset() { }

	private int PrepareStreamForRead(int readCount, long readOffset) { }

	public int Read(long offset, Byte[] buffer, int index, int count) { }

	internal int ReadByte(long offset) { }

	private void ReadStream(int readStart, int readCount, long readOffset) { }

	private void SaveBuffer() { }

	public void set_MaxSize(int value) { }

	public void set_MinimalRead(bool value) { }

	private void SwapBuffers(SavedBuffer savedBuffer) { }

}

