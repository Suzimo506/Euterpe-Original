namespace Mono.Net.Security;

internal class MonoTlsStream
{
	private readonly MonoTlsProvider provider; //Field offset: 0x10
	private readonly NetworkStream networkStream; //Field offset: 0x18
	private readonly HttpWebRequest request; //Field offset: 0x20
	private readonly MonoTlsSettings settings; //Field offset: 0x28
	private IMonoSslStream sslStream; //Field offset: 0x30
	private WebExceptionStatus status; //Field offset: 0x38
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; //Field offset: 0x3C

	internal bool CertificateValidationFailed
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal WebExceptionStatus ExceptionStatus
	{
		internal get { } //Length: 4
	}

	internal HttpWebRequest Request
	{
		internal get { } //Length: 5
	}

	public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream) { }

	internal Stream CreateStream(Byte[] buffer) { }

	[CompilerGenerated]
	internal bool get_CertificateValidationFailed() { }

	internal WebExceptionStatus get_ExceptionStatus() { }

	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	internal void set_CertificateValidationFailed(bool value) { }

}

