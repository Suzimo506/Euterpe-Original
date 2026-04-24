namespace rail;

public class IRailStreamFileImpl : RailObject, IRailStreamFile, IRailComponent
{

	internal IRailStreamFileImpl(IntPtr cPtr) { }

	public override RailResult AsyncRead(int offset, uint bytes_to_read, string user_data) { }

	public override RailResult AsyncWrite(Byte[] buff, uint bytes_to_write, string user_data) { }

	public override void Cancel() { }

	public override RailResult Close() { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override string GetFilename() { }

	public override ulong GetSize() { }

	public override void Release() { }

}

