namespace ICSharpCode.SharpZipLib.Zip;

public class ZipException : SharpZipBaseException
{

	protected ZipException(SerializationInfo info, StreamingContext context) { }

	public ZipException() { }

	public ZipException(string message) { }

}

