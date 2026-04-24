using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007BE")]
public class DBConfigLocalDlcBillboard : BaseDBConfigObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40028CF")]
	private List<LocalDlcBillboardInfo> m_Items;

	[Token(Token = "0x170006E4")]
	protected List<LocalDlcBillboardInfo> List
	{
		[Token(Token = "0x600476A")]
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600476B")]
		[Address(RVA = "0x6F5B30", Offset = "0x6F4330", Length = "0x36")]
		private set
		{
		}
	}

	[Address(RVA = "0x6FC5B0", Offset = "0x6FADB0", Length = "0x5A")]
	[Token(Token = "0x6004769")]
	public LocalDlcBillboardInfo GetLocalDlcBillboardByIndex(int index)
	{
		return null;
	}

	[Address(RVA = "0x6FC4A0", Offset = "0x6FACA0", Length = "0x105")]
	[Token(Token = "0x600476C")]
	public override void Deserialize(string str)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600476D")]
	public DBConfigLocalDlcBillboard()
	{
	}
}
