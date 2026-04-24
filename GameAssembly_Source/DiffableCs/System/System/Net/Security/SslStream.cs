namespace System.Net.Security;

public class SslStream : AuthenticatedStream
{
	private MonoTlsProvider provider; //Field offset: 0x38
	private IMonoSslStream impl; //Field offset: 0x40

	public virtual bool CanRead
	{
		 get { } //Length: 75
	}

	public virtual bool CanSeek
	{
		 get { } //Length: 3
	}

	public virtual bool CanWrite
	{
		 get { } //Length: 75
	}

	internal IMonoSslStream Impl
	{
		internal get { } //Length: 99
	}

	public virtual bool IsAuthenticated
	{
		 get { } //Length: 142
	}

	public virtual long Length
	{
		 get { } //Length: 142
	}

	public virtual long Position
	{
		 get { } //Length: 142
		 set { } //Length: 98
	}

	public virtual int ReadTimeout
	{
		 get { } //Length: 142
	}

	public virtual int WriteTimeout
	{
		 get { } //Length: 142
	}

	public SslStream(Stream innerStream) { }

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen) { }

	internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	public override Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public override void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	public virtual IAsyncResult BeginRead(Byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	public virtual IAsyncResult BeginWrite(Byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	private void CheckDisposed() { }

	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int EndRead(IAsyncResult asyncResult) { }

	public virtual void EndWrite(IAsyncResult asyncResult) { }

	public virtual void Flush() { }

	public virtual bool get_CanRead() { }

	public virtual bool get_CanSeek() { }

	public virtual bool get_CanWrite() { }

	internal IMonoSslStream get_Impl() { }

	public virtual bool get_IsAuthenticated() { }

	public virtual long get_Length() { }

	public virtual long get_Position() { }

	public virtual int get_ReadTimeout() { }

	public virtual int get_WriteTimeout() { }

	private static MonoTlsProvider GetProvider() { }

	public virtual int Read(Byte[] buffer, int offset, int count) { }

	public virtual long Seek(long offset, SeekOrigin origin) { }

	public virtual void set_Position(long value) { }

	public virtual void SetLength(long value) { }

	public virtual void Write(Byte[] buffer, int offset, int count) { }

}

