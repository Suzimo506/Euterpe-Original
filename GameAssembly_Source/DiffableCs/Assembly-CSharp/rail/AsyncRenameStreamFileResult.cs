namespace rail;

public class AsyncRenameStreamFileResult : EventBase
{
	public string old_filename; //Field offset: 0x30
	public string new_filename; //Field offset: 0x38

	public AsyncRenameStreamFileResult() { }

}

