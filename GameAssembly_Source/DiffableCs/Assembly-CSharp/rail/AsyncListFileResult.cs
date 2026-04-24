namespace rail;

public class AsyncListFileResult : EventBase
{
	public List<RailStreamFileInfo> file_list; //Field offset: 0x30
	public uint try_list_file_num; //Field offset: 0x38
	public uint all_file_num; //Field offset: 0x3C
	public uint start_index; //Field offset: 0x40

	public AsyncListFileResult() { }

}

