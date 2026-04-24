namespace UnityEngine.ResourceManagement.Util;

public class UnityWebRequestResult
{
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly long <ResponseCode>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <Method>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <Url>k__BackingField; //Field offset: 0x28

	public internal string Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public string Method
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public long ResponseCode
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Url
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public UnityWebRequestResult(UnityWebRequest request) { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public string get_Method() { }

	[CompilerGenerated]
	public long get_ResponseCode() { }

	[CompilerGenerated]
	public string get_Url() { }

	[CompilerGenerated]
	internal void set_Error(string value) { }

	public virtual string ToString() { }

}

