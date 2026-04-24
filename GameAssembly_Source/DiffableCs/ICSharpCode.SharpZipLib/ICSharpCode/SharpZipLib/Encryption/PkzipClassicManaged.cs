namespace ICSharpCode.SharpZipLib.Encryption;

public sealed class PkzipClassicManaged : PkzipClassic
{
	private Byte[] key_; //Field offset: 0x48

	public virtual int BlockSize
	{
		 get { } //Length: 6
		 set { } //Length: 94
	}

	public virtual Byte[] Key
	{
		 get { } //Length: 240
		 set { } //Length: 243
	}

	public virtual KeySizes[] LegalKeySizes
	{
		 get { } //Length: 202
	}

	public PkzipClassicManaged() { }

	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	public virtual void GenerateIV() { }

	public virtual void GenerateKey() { }

	public virtual int get_BlockSize() { }

	public virtual Byte[] get_Key() { }

	public virtual KeySizes[] get_LegalKeySizes() { }

	public virtual void set_BlockSize(int value) { }

	public virtual void set_Key(Byte[] value) { }

}

