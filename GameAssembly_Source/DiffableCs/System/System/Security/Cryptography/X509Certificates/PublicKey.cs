namespace System.Security.Cryptography.X509Certificates;

public sealed class PublicKey
{
	private static Byte[] Empty; //Field offset: 0x0
	private AsymmetricAlgorithm _key; //Field offset: 0x10
	private AsnEncodedData _keyValue; //Field offset: 0x18
	private AsnEncodedData _params; //Field offset: 0x20
	private Oid _oid; //Field offset: 0x28

	public AsnEncodedData EncodedKeyValue
	{
		 get { } //Length: 5
	}

	public AsnEncodedData EncodedParameters
	{
		 get { } //Length: 5
	}

	public AsymmetricAlgorithm Key
	{
		 get { } //Length: 434
	}

	public Oid Oid
	{
		 get { } //Length: 5
	}

	private static PublicKey() { }

	internal PublicKey(X509Certificate certificate) { }

	internal static DSA DecodeDSA(Byte[] rawPublicKey, Byte[] rawParameters) { }

	internal static RSA DecodeRSA(Byte[] rawPublicKey) { }

	public AsnEncodedData get_EncodedKeyValue() { }

	public AsnEncodedData get_EncodedParameters() { }

	public AsymmetricAlgorithm get_Key() { }

	public Oid get_Oid() { }

	private static Byte[] GetUnsignedBigInteger(Byte[] integer) { }

}

