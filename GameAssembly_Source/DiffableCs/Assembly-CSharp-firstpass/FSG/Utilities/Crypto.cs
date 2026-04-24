namespace FSG.Utilities;

public sealed class Crypto
{
	private readonly object cryptLock; //Field offset: 0x10
	private readonly string pw; //Field offset: 0x18
	private readonly Byte[] salt; //Field offset: 0x20
	private Aes aes; //Field offset: 0x28
	private ICryptoTransform currentEncryptor; //Field offset: 0x30
	private ICryptoTransform currentDecryptor; //Field offset: 0x38

	private ICryptoTransform decryptor
	{
		private get { } //Length: 132
	}

	private ICryptoTransform encryptor
	{
		private get { } //Length: 132
	}

	public Crypto(string pw, string salt) { }

	public Byte[] Decrypt(Byte[] input) { }

	public Byte[] Encrypt(Byte[] input) { }

	private ICryptoTransform get_decryptor() { }

	private ICryptoTransform get_encryptor() { }

}

