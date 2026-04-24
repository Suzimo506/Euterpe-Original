namespace ICSharpCode.SharpZipLib.Encryption;

internal class PkzipClassicCryptoBase
{
	private UInt32[] keys; //Field offset: 0x10

	public PkzipClassicCryptoBase() { }

	protected void Reset() { }

	protected void SetKeys(Byte[] keyData) { }

	protected byte TransformByte() { }

	protected void UpdateKeys(byte ch) { }

}

