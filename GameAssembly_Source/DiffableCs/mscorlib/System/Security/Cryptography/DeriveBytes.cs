namespace System.Security.Cryptography;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class DeriveBytes : IDisposable
{

	protected DeriveBytes() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract Byte[] GetBytes(int cb) { }

}

