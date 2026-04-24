namespace Newtonsoft.Json.Serialization;

public sealed class ExtensionDataSetter : MulticastDelegate
{

	public ExtensionDataSetter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object o, string key, object value, AsyncCallback callback, object object) { }

	public override void EndInvoke(IAsyncResult result) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override void Invoke(object o, string key, object value) { }

}

