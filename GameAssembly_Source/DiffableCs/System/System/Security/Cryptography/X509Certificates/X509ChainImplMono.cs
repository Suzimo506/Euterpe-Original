namespace System.Security.Cryptography.X509Certificates;

internal class X509ChainImplMono : X509ChainImpl
{
	private static X509ChainStatus[] Empty; //Field offset: 0x0
	private StoreLocation location; //Field offset: 0x10
	private X509ChainElementCollection elements; //Field offset: 0x18
	private X509ChainPolicy policy; //Field offset: 0x20

	public virtual X509ChainPolicy ChainPolicy
	{
		 set { } //Length: 12
	}

	public virtual bool IsValid
	{
		 get { } //Length: 3
	}

	private static X509ChainImplMono() { }

	public X509ChainImplMono(bool useMachineContext) { }

	public virtual bool get_IsValid() { }

	public virtual void set_ChainPolicy(X509ChainPolicy value) { }

}

