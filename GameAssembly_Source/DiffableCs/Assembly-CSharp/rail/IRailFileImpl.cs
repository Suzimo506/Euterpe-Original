namespace rail;

public class IRailFileImpl : RailObject, IRailFile, IRailComponent
{

	internal IRailFileImpl(IntPtr cPtr) { }

	public override RailResult AsyncRead(uint bytes_to_read, string user_data) { }

	public override RailResult AsyncWrite(Byte[] buffer, uint bytes_to_write, string user_data) { }

	public override void Close() { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override string GetFilename() { }

	public override uint GetSize() { }

	public override uint Read(Byte[] buff, uint bytes_to_read, out RailResult result) { }

	public override uint Read(Byte[] buff, uint bytes_to_read) { }

	public override void Release() { }

	public override uint Write(Byte[] buff, uint bytes_to_write, out RailResult result) { }

	public override uint Write(Byte[] buff, uint bytes_to_write) { }

}

