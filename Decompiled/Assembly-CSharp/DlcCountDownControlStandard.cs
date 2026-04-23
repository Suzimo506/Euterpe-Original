using System;
using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000108")]
public class DlcCountDownControlStandard : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000686")]
	[SerializeField]
	private RectTransform m_CountDownBaseTransform;

	[Token(Token = "0x4000687")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private Text m_CountDownTitleText;

	[SerializeField]
	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x28")]
	private Text m_CountDownText;

	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x30")]
	private DLCInfoActiveTime m_ActiveTime;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400068A")]
	private int m_JsonIndex;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400068B")]
	private DateTime m_EndTime;

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x441F30", Offset = "0x440730", Length = "0x164")]
	public void Init(int albumJsonIndex)
	{
	}

	[Address(RVA = "0x4420A0", Offset = "0x4408A0", Length = "0xA2")]
	[Token(Token = "0x60007BB")]
	private void ResetCountDown()
	{
	}

	[Address(RVA = "0x441C40", Offset = "0x440440", Length = "0x245")]
	[Token(Token = "0x60007BC")]
	private bool CheckNeedToDisplay()
	{
		return default(bool);
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x441E90", Offset = "0x440690", Length = "0x9D")]
	private DLCInfoActiveTime InitDlcInfoActiveTime(int jsonIndex)
	{
		return null;
	}

	[Address(RVA = "0x442150", Offset = "0x440950", Length = "0xA0")]
	[Token(Token = "0x60007BE")]
	private bool SpecialLogicForMaiMaiDX_SkipShowCountdown()
	{
		return default(bool);
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DlcCountDownControlStandard()
	{
	}
}
