namespace System.Security.Cryptography;

[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class RC2 : SymmetricAlgorithm
{
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8
	protected int EffectiveKeySizeValue; //Field offset: 0x48

	public override int EffectiveKeySize
	{
		 get { } //Length: 11
	}

	public virtual int KeySize
	{
		 get { } //Length: 4
		 set { } //Length: 131
	}

	private static RC2() { }

	protected RC2() { }

	public static RC2 Create() { }

	public override int get_EffectiveKeySize() { }

	public virtual int get_KeySize() { }

	public virtual void set_KeySize(int value) { }

}

