using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200093C")]
public class PnlDlcColorGradientItem : SerializedMonoBehaviour, IGradientItem
{
	[Token(Token = "0x2000DB3")]
	private struct ColorGradientInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4004084")]
		public Color toColor;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4004085")]
		public float changeTime;
	}

	[Token(Token = "0x40031ED")]
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	private Graphic m_Graphic;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40031EE")]
	[SerializeField]
	private ColorGradientInfo m_DefaultColorGradientInfo;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40031EF")]
	[SerializeField]
	private Dictionary<int, ColorGradientInfo> m_SpecialColorGradientInfoDic;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40031F0")]
	private Tweener m_Tweener;

	[Token(Token = "0x40031F1")]
	[FieldOffset(Offset = "0x88")]
	private ColorGradientInfo m_PrevoisColorGradientInfo;

	[Token(Token = "0x60053E0")]
	[Address(RVA = "0x824970", Offset = "0x823170", Length = "0xBA")]
	public void Show(int jsonIndex)
	{
	}

	[Token(Token = "0x60053E1")]
	[Address(RVA = "0x8248A0", Offset = "0x8230A0", Length = "0xC9")]
	private void SetNewColor(ref ColorGradientInfo gradientInfo)
	{
	}

	[Address(RVA = "0x824860", Offset = "0x823060", Length = "0x3B")]
	[Token(Token = "0x60053E2")]
	public void StopShow()
	{
	}

	[Token(Token = "0x60053E3")]
	[Address(RVA = "0x824860", Offset = "0x823060", Length = "0x3B")]
	private void KillTweener()
	{
	}

	[Token(Token = "0x60053E4")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public PnlDlcColorGradientItem()
	{
	}
}
