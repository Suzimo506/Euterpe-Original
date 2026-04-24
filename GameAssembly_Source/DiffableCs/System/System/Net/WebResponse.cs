namespace System.Net;

public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{

	public override WebHeaderCollection Headers
	{
		 get { } //Length: 53
	}

	public override Uri ResponseUri
	{
		 get { } //Length: 53
	}

	protected WebResponse() { }

	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override void Close() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override WebHeaderCollection get_Headers() { }

	public override Uri get_ResponseUri() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override Stream GetResponseStream() { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

