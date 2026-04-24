namespace rail;

public interface IRailFile : IRailComponent
{

	public RailResult AsyncRead(uint bytes_to_read, string user_data) { }

	public RailResult AsyncWrite(Byte[] buffer, uint bytes_to_write, string user_data) { }

	public void Close() { }

	public string GetFilename() { }

	public uint GetSize() { }

	public uint Read(Byte[] buff, uint bytes_to_read, out RailResult result) { }

	public uint Read(Byte[] buff, uint bytes_to_read) { }

	public uint Write(Byte[] buff, uint bytes_to_write, out RailResult result) { }

	public uint Write(Byte[] buff, uint bytes_to_write) { }

}

