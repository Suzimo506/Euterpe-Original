using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200091C")]
public class DLCInfoMikuPurchaseControl : DLCInfoBasePurchaseControl
{
	[Token(Token = "0x40030FA")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Image m_ImgStaticPurchasedIcon;

	[SerializeField]
	[Token(Token = "0x40030FB")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_PurchasedAnimator;

	[SerializeField]
	[Token(Token = "0x40030FC")]
	private static string s_MikuAnimation;

	[Token(Token = "0x60052A6")]
	[Address(RVA = "0x4258F0", Offset = "0x4240F0", Length = "0x86")]
	public override void Refresh()
	{
	}

	[Address(RVA = "0x425870", Offset = "0x424070", Length = "0x74")]
	[Token(Token = "0x60052A7")]
	public override void OnPurchaseSuccess()
	{
	}

	[Token(Token = "0x60052A8")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public DLCInfoMikuPurchaseControl()
	{
	}
}
