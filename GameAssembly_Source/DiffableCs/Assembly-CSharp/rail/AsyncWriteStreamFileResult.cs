namespace rail;

public class AsyncWriteStreamFileResult : EventBase
{
	public uint written_length; //Field offset: 0x30
	public int offset; //Field offset: 0x34
	public uint try_write_length; //Field offset: 0x38
	public string filename; //Field offset: 0x40

	public AsyncWriteStreamFileResult() { }

}

