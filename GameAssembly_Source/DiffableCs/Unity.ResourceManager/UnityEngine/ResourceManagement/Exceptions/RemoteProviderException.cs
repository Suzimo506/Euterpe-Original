namespace UnityEngine.ResourceManagement.Exceptions;

public class RemoteProviderException : ProviderException
{
	[CompilerGenerated]
	private readonly UnityWebRequestResult <WebRequestResult>k__BackingField; //Field offset: 0x90

	public UnityWebRequestResult WebRequestResult
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public RemoteProviderException(string message, IResourceLocation location = null, UnityWebRequestResult uwrResult = null, Exception innerException = null) { }

	[CompilerGenerated]
	public UnityWebRequestResult get_WebRequestResult() { }

	public virtual string ToString() { }

}

