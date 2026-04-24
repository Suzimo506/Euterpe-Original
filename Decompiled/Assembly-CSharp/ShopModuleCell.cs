using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200015E")]
public class ShopModuleCell : MonoBehaviour, IFastPoolItem
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008AA")]
	public ShopGoodsCell[] cells;

	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x20")]
	private ShopModule m_Module;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008AC")]
	private PnlShop m_Parent;

	[Token(Token = "0x170000D8")]
	private ShopManager.ModuleLayout type
	{
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x62E670", Offset = "0x62CE70", Length = "0xE")]
		get
		{
			return default(ShopManager.ModuleLayout);
		}
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x62E530", Offset = "0x62CD30", Length = "0x13F")]
	public void RefreshCellsInfo(ShopModule module, PnlShop parent)
	{
	}

	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x62E430", Offset = "0x62CC30", Length = "0x7A")]
	private void InitCellsInfo()
	{
	}

	[Address(RVA = "0x62E4B0", Offset = "0x62CCB0", Length = "0x74")]
	[Token(Token = "0x6000A11")]
	public void OnFastInstantiate()
	{
	}

	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x62E430", Offset = "0x62CC30", Length = "0x7A")]
	public void OnFastDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000A13")]
	public ShopModuleCell()
	{
	}
}
