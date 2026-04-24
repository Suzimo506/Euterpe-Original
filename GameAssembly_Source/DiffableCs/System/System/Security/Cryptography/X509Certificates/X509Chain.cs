namespace System.Security.Cryptography.X509Certificates;

public class X509Chain : IDisposable
{
	private X509ChainImpl impl; //Field offset: 0x10

	public X509ChainPolicy ChainPolicy
	{
		 set { } //Length: 152
	}

	internal X509ChainImpl Impl
	{
		internal get { } //Length: 109
	}

	public X509Chain() { }

	public X509Chain(bool useMachineContext) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	internal X509ChainImpl get_Impl() { }

	public void set_ChainPolicy(X509ChainPolicy value) { }

}

