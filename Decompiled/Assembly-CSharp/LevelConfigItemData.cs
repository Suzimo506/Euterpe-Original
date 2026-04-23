using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

[Token(Token = "0x2000148")]
public class LevelConfigItemData
{
	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x10")]
	public BaseDataObject dbData;

	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x18")]
	public IData iData;

	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x20")]
	public string itemType;

	[Token(Token = "0x170000B6")]
	public bool isUnLock
	{
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x5D3070", Offset = "0x5D1870", Length = "0x2B1")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B7")]
	public bool isLove
	{
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x5D2E80", Offset = "0x5D1680", Length = "0x10C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B8")]
	public bool isRandom
	{
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x5D2F90", Offset = "0x5D1790", Length = "0xD2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600093C")]
	[Address(RVA = "0x5D2DC0", Offset = "0x5D15C0", Length = "0xB1")]
	public LevelConfigItemData(BaseDataObject tempDbData, IData tempIData, string tempItemType)
	{
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0x5D2CA0", Offset = "0x5D14A0", Length = "0x116")]
	private void CheckIData()
	{
	}
}
