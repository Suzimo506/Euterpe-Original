namespace rail;

public interface IRailHttpResponse : IRailComponent
{

	public string GetContentEncoding() { }

	public string GetContentLanguage() { }

	public uint GetContentLength() { }

	public string GetContentRange() { }

	public string GetContentType() { }

	public int GetHttpResponseCode() { }

	public string GetLastModified() { }

	public string GetResponseBodyData() { }

	public RailResult GetResponseHeaderKeys(List<String> header_keys) { }

	public string GetResponseHeaderValue(string header_key) { }

}

