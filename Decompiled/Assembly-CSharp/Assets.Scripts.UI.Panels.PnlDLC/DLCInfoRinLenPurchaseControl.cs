using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200091D")]
public class DLCInfoRinLenPurchaseControl : DLCInfoBasePurchaseControl
{
	[SerializeField]
	[Token(Token = "0x40030FD")]
	[FieldOffset(Offset = "0x18")]
	private Image m_ImgStaticPurchasedIcon;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40030FE")]
	[SerializeField]
	private Animator m_PurchasedAnimator;

	[SerializeField]
	[Token(Token = "0x40030FF")]
	private static string s_RinLenAnimation;

	[Token(Token = "0x60052AA")]
	[Address(RVA = "0x425A40", Offset = "0x424240", Length = "0x86")]
	public override void Refresh()
	{
	}

	[Address(RVA = "0x4259C0", Offset = "0x4241C0", Length = "0x74")]
	[Token(Token = "0x60052AB")]
	public override void OnPurchaseSuccess()
	{
	}

	[Token(Token = "0x60052AC")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public DLCInfoRinLenPurchaseControl()
	{
	}
}
