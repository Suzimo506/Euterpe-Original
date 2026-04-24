namespace Newtonsoft.Json.Serialization;

public sealed class ExtensionDataGetter : MulticastDelegate
{

	public ExtensionDataGetter(object object, IntPtr method) { }

	public override IAsyncResult BeginInvoke(object o, AsyncCallback callback, object object) { }

	public override IEnumerable<KeyValuePair`2<Object, Object>> EndInvoke(IAsyncResult result) { }

	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public override IEnumerable<KeyValuePair`2<Object, Object>> Invoke(object o) { }

}

