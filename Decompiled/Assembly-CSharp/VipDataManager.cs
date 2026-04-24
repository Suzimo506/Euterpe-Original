using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

[Token(Token = "0x2000057")]
public class VipDataManager : Singleton<VipDataManager>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400020F")]
	public List<VipItemData> vipAlbumItemDatas;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000210")]
	public List<VipChaItemData> vipChaItemDatas;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000211")]
	public List<VipElfinItemData> vipElfinItemDatas;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000212")]
	private bool m_IsInit;

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x4ECCA0", Offset = "0x4EB4A0", Length = "0x12")]
	public void InitVipData()
	{
	}

	[Address(RVA = "0x4ECE60", Offset = "0x4EB660", Length = "0x9F3")]
	[Token(Token = "0x600029A")]
	public void RefreshAllVIpData()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x4ECCC0", Offset = "0x4EB4C0", Length = "0x194")]
	public bool IsItemWithinVIPUnlockRange(int listIndex, string type)
	{
		return default(bool);
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x4ED860", Offset = "0x4EC060", Length = "0xC8")]
	public VipDataManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
