using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200086F")]
public class CheckUpdateToDisableBtnAndSetGray : MonoBehaviour
{
	[Token(Token = "0x4002C1C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button[] m_Btns;

	[Token(Token = "0x4002C1D")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private float m_FrameKeyTime;

	[Token(Token = "0x4002C1F")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_Anima;

	[Token(Token = "0x1700086D")]
	public Action callback
	{
		[CompilerGenerated]
		[Token(Token = "0x6004D19")]
		[Address(RVA = "0x46EF20", Offset = "0x46D720", Length = "0x5")]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x48F110", Offset = "0x48D910", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6004D1B")]
	[Address(RVA = "0x60C6C0", Offset = "0x60AEC0", Length = "0xEE")]
	public void SetBtnInteractable()
	{
	}

	[Address(RVA = "0x60C7B0", Offset = "0x60AFB0", Length = "0x6B")]
	[Token(Token = "0x6004D1C")]
	public void SetBtnInteractable(Animator anima, Button[] btns, float frameKeyTime = -1f)
	{
	}

	[Token(Token = "0x6004D1D")]
	[Address(RVA = "0x60C5B0", Offset = "0x60ADB0", Length = "0x107")]
	private void OnSetBtnInteractable()
	{
	}

	[Token(Token = "0x6004D1E")]
	[Address(RVA = "0x60C4C0", Offset = "0x60ACC0", Length = "0xE0")]
	private void AniFrameEvt_SetBtnInteractable()
	{
	}

	[Token(Token = "0x6004D1F")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public CheckUpdateToDisableBtnAndSetGray()
	{
	}
}
