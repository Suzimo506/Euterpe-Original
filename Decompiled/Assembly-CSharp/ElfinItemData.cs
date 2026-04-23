using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

[Token(Token = "0x2000143")]
public class ElfinItemData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007DB")]
	public ElfinInfo elfinInfo;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007DC")]
	public IData iData;

	[Token(Token = "0x170000AE")]
	public ElfinType elfinType
	{
		[Address(RVA = "0x447530", Offset = "0x445D30", Length = "0x1B")]
		[Token(Token = "0x600091A")]
		get
		{
			return default(ElfinType);
		}
	}

	[Token(Token = "0x170000AF")]
	public bool isUnLock
	{
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x447700", Offset = "0x445F00", Length = "0xB6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B0")]
	public bool isNew
	{
		[Address(RVA = "0x4475F0", Offset = "0x445DF0", Length = "0x6B")]
		[Token(Token = "0x600091C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x4477C0", Offset = "0x445FC0", Length = "0x88")]
		set
		{
		}
	}

	[Token(Token = "0x170000B1")]
	public bool isLove
	{
		[Address(RVA = "0x447550", Offset = "0x445D50", Length = "0x97")]
		[Token(Token = "0x600091E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B2")]
	public bool isRandom
	{
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x447660", Offset = "0x445E60", Length = "0x97")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x447490", Offset = "0x445C90", Length = "0x99")]
	private void CheckIData()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6000921")]
	public ElfinItemData()
	{
	}
}
