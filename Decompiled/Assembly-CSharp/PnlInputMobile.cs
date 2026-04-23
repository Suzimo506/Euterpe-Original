using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000125")]
public class PnlInputMobile : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000709")]
	public AudioClip clickSfx;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400070A")]
	private bool m_IsLeftRight;

	[FieldOffset(Offset = "0x121")]
	[Token(Token = "0x400070B")]
	private bool m_IsTouchReverse;

	[FieldOffset(Offset = "0x122")]
	[Token(Token = "0x400070C")]
	private bool m_IsAutoFever;

	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x128")]
	public Dictionary<Toggle, MobileInputType> bindToggles;

	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x130")]
	public List<GameObject> normalActives;

	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x138")]
	public List<GameObject> reverseActives;

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x7A1450", Offset = "0x79FC50", Length = "0x2C7")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x7A1720", Offset = "0x79FF20", Length = "0x85")]
	public override void OnDisablePnl()
	{
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x7A19C0", Offset = "0x7A01C0", Length = "0x150")]
	private void ToggleHandler(Toggle tgl, bool state)
	{
	}

	[Address(RVA = "0x7A17B0", Offset = "0x79FFB0", Length = "0x7")]
	[Token(Token = "0x6000845")]
	private void SetAutoFever(bool autoFever)
	{
	}

	[Address(RVA = "0x7A17D0", Offset = "0x79FFD0", Length = "0x1EC")]
	[Token(Token = "0x6000846")]
	private void SetTouchReverse(bool reverse)
	{
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0x7A17C0", Offset = "0x79FFC0", Length = "0x7")]
	private void SetLeftRight(bool leftRight)
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x7A1B30", Offset = "0x7A0330", Length = "0xCC")]
	public PnlInputMobile()
	{
	}
}
