using Cpp2ILInjected;

[Token(Token = "0x200001F")]
public abstract class DataModel
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void Release()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60000D0")]
	protected DataModel()
	{
	}
}
