namespace UnityEngine;

[Obsolete]
public class WWW : CustomYieldInstruction, IDisposable
{
	private UnityWebRequest _uwr; //Field offset: 0x10
	private Dictionary<String, String> _responseHeaders; //Field offset: 0x18

	public Byte[] bytes
	{
		 get { } //Length: 131
	}

	public string error
	{
		 get { } //Length: 270
	}

	public bool isDone
	{
		 get { } //Length: 29
	}

	public virtual bool keepWaiting
	{
		 get { } //Length: 38
	}

	public Dictionary<String, String> responseHeaders
	{
		 get { } //Length: 390
	}

	public string text
	{
		 get { } //Length: 124
	}

	public string url
	{
		 get { } //Length: 29
	}

	public WWW(string url) { }

	public WWW(string url, Byte[] postData) { }

	public WWW(string url, Byte[] postData, Dictionary<String, String> headers) { }

	public override void Dispose() { }

	public static string EscapeURL(string s) { }

	public static string EscapeURL(string s, Encoding e) { }

	public Byte[] get_bytes() { }

	public string get_error() { }

	public bool get_isDone() { }

	public virtual bool get_keepWaiting() { }

	public Dictionary<String, String> get_responseHeaders() { }

	public string get_text() { }

	public string get_url() { }

	private bool WaitUntilDoneIfPossible() { }

}

