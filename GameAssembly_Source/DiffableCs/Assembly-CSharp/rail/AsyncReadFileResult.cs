namespace rail;

public class AsyncReadFileResult : EventBase
{
	public uint try_read_length; //Field offset: 0x30
	public int offset; //Field offset: 0x34
	public string data; //Field offset: 0x38
	public string filename; //Field offset: 0x40

	public AsyncReadFileResult() { }

}

