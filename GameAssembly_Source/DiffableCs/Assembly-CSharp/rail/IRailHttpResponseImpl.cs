namespace rail;

public class IRailHttpResponseImpl : RailObject, IRailHttpResponse, IRailComponent
{

	internal IRailHttpResponseImpl(IntPtr cPtr) { }

	protected virtual void Finalize() { }

	public override ulong GetComponentVersion() { }

	public override string GetContentEncoding() { }

	public override string GetContentLanguage() { }

	public override uint GetContentLength() { }

	public override string GetContentRange() { }

	public override string GetContentType() { }

	public override int GetHttpResponseCode() { }

	public override string GetLastModified() { }

	public override string GetResponseBodyData() { }

	public override RailResult GetResponseHeaderKeys(List<String> header_keys) { }

	public override string GetResponseHeaderValue(string header_key) { }

	public override void Release() { }

}

