namespace rail;

public interface IRailHttpSession : IRailComponent
{

	public RailResult AsyncSendRequest(string url, string user_data) { }

	public RailResult SetParameters(List<RailKeyValue> parameters) { }

	public RailResult SetPostBodyContent(string body_content) { }

	public RailResult SetRequestHeaders(List<String> headers) { }

	public RailResult SetRequestMethod(RailHttpSessionMethod method) { }

	public RailResult SetRequestTimeOut(uint timeout_secs) { }

}

