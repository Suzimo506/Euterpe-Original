using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200096B")]
public class PnlRoleSkinItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40033AF")]
	[FieldOffset(Offset = "0x18")]
	private Image m_ImgBg;

	[SerializeField]
	[Token(Token = "0x40033B0")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_SelectedObj;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40033B1")]
	[SerializeField]
	private Image m_ImgSkin;

	[Token(Token = "0x40033B2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject m_PurchaseTipsObj;

	[Token(Token = "0x40033B3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_TryOutTipsObj;

	[SerializeField]
	[Token(Token = "0x40033B4")]
	[FieldOffset(Offset = "0x40")]
	private Sprite m_LockedSprite;

	[Token(Token = "0x40033B5")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite m_UnLockedSprite;

	[Token(Token = "0x170008FF")]
	public bool isBuy
	{
		[Address(RVA = "0x50B3E0", Offset = "0x509BE0", Length = "0x5")]
		[Token(Token = "0x60055FB")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055FC")]
		[CompilerGenerated]
		[Address(RVA = "0x642820", Offset = "0x641020", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000900")]
	public bool isTryOut
	{
		[CompilerGenerated]
		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x642810", Offset = "0x641010", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60055FE")]
		[CompilerGenerated]
		[Address(RVA = "0x642830", Offset = "0x641030", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x60055FF")]
	[Address(RVA = "0x642610", Offset = "0x640E10", Length = "0x1D7")]
	public void RefreshSkinItem(int characterIndex, RoleSkin roleSkin)
	{
	}

	[Address(RVA = "0x6425E0", Offset = "0x640DE0", Length = "0x28")]
	[Token(Token = "0x6005600")]
	public void OnSelected()
	{
	}

	[Token(Token = "0x6005601")]
	[Address(RVA = "0x6425B0", Offset = "0x640DB0", Length = "0x20")]
	public void OnDeselected()
	{
	}

	[Address(RVA = "0x6427F0", Offset = "0x640FF0", Length = "0x1E")]
	[Token(Token = "0x6005602")]
	public void SetDressed(bool isDressed)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005603")]
	public PnlRoleSkinItem()
	{
	}
}
