namespace Mono.Unity;

internal class UnityTlsProvider : MonoTlsProvider
{

	public virtual Guid ID
	{
		 get { } //Length: 99
	}

	public virtual string Name
	{
		 get { } //Length: 43
	}

	public virtual SslProtocols SupportedProtocols
	{
		 get { } //Length: 6
	}

	internal virtual bool SupportsCleanShutdown
	{
		internal get { } //Length: 3
	}

	public virtual bool SupportsConnectionInfo
	{
		 get { } //Length: 3
	}

	public virtual bool SupportsMonoExtensions
	{
		 get { } //Length: 3
	}

	public virtual bool SupportsSslStream
	{
		 get { } //Length: 3
	}

	public UnityTlsProvider() { }

	public virtual IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings = null) { }

	internal virtual IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	public virtual Guid get_ID() { }

	public virtual string get_Name() { }

	public virtual SslProtocols get_SupportedProtocols() { }

	internal virtual bool get_SupportsCleanShutdown() { }

	public virtual bool get_SupportsConnectionInfo() { }

	public virtual bool get_SupportsMonoExtensions() { }

	public virtual bool get_SupportsSslStream() { }

	internal virtual bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11) { }

}

