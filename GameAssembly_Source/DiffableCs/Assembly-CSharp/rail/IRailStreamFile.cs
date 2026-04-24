namespace rail;

public interface IRailStreamFile : IRailComponent
{

	public RailResult AsyncRead(int offset, uint bytes_to_read, string user_data) { }

	public RailResult AsyncWrite(Byte[] buff, uint bytes_to_write, string user_data) { }

	public void Cancel() { }

	public RailResult Close() { }

	public string GetFilename() { }

	public ulong GetSize() { }

}

