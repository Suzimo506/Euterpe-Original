namespace rail;

public class IRailHttpSessionImpl : RailObject, IRailHttpSession, IRailComponent
{

	internal IRailHttpSessionImpl(IntPtr cPtr) { }

	public override RailResult AsyncSendRequest(string url, string user_data) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override void Release() { }

	public override RailResult SetParameters(List<RailKeyValue> parameters) { }

	public override RailResult SetPostBodyContent(string body_content) { }

	public override RailResult SetRequestHeaders(List<String> headers) { }

	public override RailResult SetRequestMethod(RailHttpSessionMethod method) { }

	public override RailResult SetRequestTimeOut(uint timeout_secs) { }

}

