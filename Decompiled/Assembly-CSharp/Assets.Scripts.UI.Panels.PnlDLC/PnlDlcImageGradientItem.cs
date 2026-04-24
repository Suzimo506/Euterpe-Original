using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000940")]
public class PnlDlcImageGradientItem : SerializedMonoBehaviour, IGradientItem
{
	[Token(Token = "0x2000DB6")]
	private struct ImageGradientInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4004090")]
		public Sprite toSprite;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4004091")]
		public float changeTime;
	}

	[SerializeField]
	[Token(Token = "0x40031FB")]
	[FieldOffset(Offset = "0x58")]
	private Image m_MainImage;

	[Token(Token = "0x40031FC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image m_GradientImage;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40031FD")]
	[SerializeField]
	private ImageGradientInfo m_DefaultImageGradientInfo;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40031FE")]
	[SerializeField]
	private Dictionary<int, ImageGradientInfo> m_SpecialImageGradientInfoDic;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40031FF")]
	private Tweener m_MainTweener;

	[Token(Token = "0x4003200")]
	[FieldOffset(Offset = "0x88")]
	private Tweener m_GradientTwneener;

	[Token(Token = "0x4003201")]
	[FieldOffset(Offset = "0x90")]
	private Color m_HideColor;

	[Token(Token = "0x4003202")]
	[FieldOffset(Offset = "0xA0")]
	private Color m_ShowColor;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4003203")]
	private ImageGradientInfo m_previousGradientInfo;

	[Address(RVA = "0x826020", Offset = "0x824820", Length = "0x159")]
	[Token(Token = "0x60053FB")]
	public void Show(int jsonIndex)
	{
	}

	[Address(RVA = "0x825DA0", Offset = "0x8245A0", Length = "0x278")]
	[Token(Token = "0x60053FC")]
	private void SetNewGradientImage(ref ImageGradientInfo gradientInfo)
	{
	}

	[Address(RVA = "0x826180", Offset = "0x824980", Length = "0x14A")]
	[Token(Token = "0x60053FD")]
	public void StopShow()
	{
	}

	[Token(Token = "0x60053FE")]
	[Address(RVA = "0x825D60", Offset = "0x824560", Length = "0x37")]
	private void KillOneTweener(ref Tweener tweener)
	{
	}

	[Token(Token = "0x60053FF")]
	[Address(RVA = "0x8262D0", Offset = "0x824AD0", Length = "0x97")]
	public PnlDlcImageGradientItem()
	{
	}
}
