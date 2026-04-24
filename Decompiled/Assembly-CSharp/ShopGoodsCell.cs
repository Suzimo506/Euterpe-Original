using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200015D")]
public class ShopGoodsCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008A1")]
	public int index;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008A2")]
	private string m_Name;

	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x28")]
	private string m_Link;

	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x30")]
	private Image m_Img;

	[SerializeField]
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x38")]
	private LongSongNameController m_Txt;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008A6")]
	[SerializeField]
	private GameObject m_LoadingUi;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008A7")]
	private Button m_Btn;

	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x50")]
	private Color m_EmptyColor;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008A9")]
	private ModuleGoods m_ModuleGoods;

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x62DE00", Offset = "0x62C600", Length = "0x102")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x62DF10", Offset = "0x62C710", Length = "0x1CB")]
	public void InitGoodsInfo(bool isEmpty = false)
	{
	}

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x62E340", Offset = "0x62CB40", Length = "0xA")]
	public void SetEmpty()
	{
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x62E160", Offset = "0x62C960", Length = "0x1DE")]
	public void RefreshGoodsInfo(ModuleGoods goods, int idx)
	{
	}

	[Address(RVA = "0x62E0E0", Offset = "0x62C8E0", Length = "0x7F")]
	[Token(Token = "0x6000A0B")]
	private void OnClickOpenUrl()
	{
	}

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ShopGoodsCell()
	{
	}
}
