namespace Newtonsoft.Json.Serialization;

public sealed class SerializationErrorCallback : MulticastDelegate
{

	public SerializationErrorCallback(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

}

