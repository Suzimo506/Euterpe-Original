using System.Collections.Generic;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000811")]
public class DBTouch : BaseDatabase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002A0D")]
	private List<CatchInput> m_CatchInputs;

	[Token(Token = "0x600491D")]
	[Address(RVA = "0x102F560", Offset = "0x102DD60", Length = "0x76")]
	public void JkRefreshCatchTime(int index, float time)
	{
	}

	[Token(Token = "0x600491E")]
	[Address(RVA = "0x102F5E0", Offset = "0x102DDE0", Length = "0x70")]
	public void JkSetCatchTime(int index, float time)
	{
	}

	[Token(Token = "0x600491F")]
	[Address(RVA = "0x78FD10", Offset = "0x78E510", Length = "0x12")]
	public override void Release()
	{
	}

	[Token(Token = "0x6004920")]
	[Address(RVA = "0x102F2F0", Offset = "0x102DAF0", Length = "0xD1")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004921")]
	[Address(RVA = "0x102F3D0", Offset = "0x102DBD0", Length = "0x68")]
	public CatchInput GetCatchInput(int index)
	{
		return null;
	}

	[Token(Token = "0x6004922")]
	[Address(RVA = "0x102F440", Offset = "0x102DC40", Length = "0x11F")]
	public int IsCatching(bool isGround, float time)
	{
		return default(int);
	}

	[Token(Token = "0x6004923")]
	[Address(RVA = "0x102F660", Offset = "0x102DE60", Length = "0x51")]
	public DBTouch()
	{
	}
}
