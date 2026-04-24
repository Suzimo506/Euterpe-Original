namespace NAudio.Wave;

public abstract class WaveStream : Stream, IWaveProvider
{

	public override int BlockAlign
	{
		 get { } //Length: 54
	}

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

	public abstract WaveFormat WaveFormat
	{
		 get { } //Length: 0
	}

	protected WaveStream() { }

	public virtual void Flush() { }

	public override int get_BlockAlign() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	public abstract WaveFormat get_WaveFormat() { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void SetLength(long length) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

