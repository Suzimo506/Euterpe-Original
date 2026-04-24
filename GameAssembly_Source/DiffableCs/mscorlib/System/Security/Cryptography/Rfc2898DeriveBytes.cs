namespace System.Security.Cryptography;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Rfc2898DeriveBytes : DeriveBytes
{
	private Byte[] m_buffer; //Field offset: 0x10
	private Byte[] m_salt; //Field offset: 0x18
	private HMACSHA1 m_hmacsha1; //Field offset: 0x20
	private Byte[] m_password; //Field offset: 0x28
	private uint m_iterations; //Field offset: 0x30
	private uint m_block; //Field offset: 0x34
	private int m_startIndex; //Field offset: 0x38
	private int m_endIndex; //Field offset: 0x3C

	public int IterationCount
	{
		 set { } //Length: 135
	}

	public Byte[] Salt
	{
		 set { } //Length: 264
	}

	public Rfc2898DeriveBytes(string password, Byte[] salt) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt, int iterations) { }

	public Rfc2898DeriveBytes(Byte[] password, Byte[] salt, int iterations) { }

	protected virtual void Dispose(bool disposing) { }

	private Byte[] Func() { }

	public virtual Byte[] GetBytes(int cb) { }

	private void Initialize() { }

	public void set_IterationCount(int value) { }

	public void set_Salt(Byte[] value) { }

}

