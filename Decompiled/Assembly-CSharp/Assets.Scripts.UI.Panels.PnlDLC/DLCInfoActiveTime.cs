using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000916")]
internal class DLCInfoActiveTime : MonoBehaviour
{
	[Token(Token = "0x40030EB")]
	[FieldOffset(Offset = "0x18")]
	protected Text m_TxtTimeRemainTitle;

	[Token(Token = "0x40030EC")]
	[FieldOffset(Offset = "0x20")]
	protected Text m_TxtTimeRemain;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40030ED")]
	private DateTime m_EndTime;

	[Token(Token = "0x40030EE")]
	[FieldOffset(Offset = "0x30")]
	private DateTime m_NowTime;

	[Token(Token = "0x40030EF")]
	[FieldOffset(Offset = "0x38")]
	private float m_Tick;

	[Token(Token = "0x40030F0")]
	[FieldOffset(Offset = "0x3C")]
	private readonly float m_RefreshInterval;

	[Address(RVA = "0x4248A0", Offset = "0x4230A0", Length = "0x45")]
	[Token(Token = "0x600527E")]
	private void Update()
	{
	}

	[Address(RVA = "0x4242F0", Offset = "0x422AF0", Length = "0xA9")]
	[Token(Token = "0x600527F")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005280")]
	[Address(RVA = "0x424140", Offset = "0x422940", Length = "0x1A0")]
	internal void Init(DateTime endTime, Text txtTime, Text txtTitle = null)
	{
	}

	[Token(Token = "0x6005281")]
	[Address(RVA = "0x4243A0", Offset = "0x422BA0", Length = "0xE")]
	private void OnLanguageChanged(int languageIndex)
	{
	}

	[Token(Token = "0x6005282")]
	[Address(RVA = "0x4240A0", Offset = "0x4228A0", Length = "0x9B")]
	private void AutoRefreshCountdown()
	{
	}

	[Address(RVA = "0x424800", Offset = "0x423000", Length = "0x9C")]
	[Token(Token = "0x6005283")]
	protected virtual void RefreshTimeRemainTitleText()
	{
	}

	[Token(Token = "0x6005284")]
	[Address(RVA = "0x4243B0", Offset = "0x422BB0", Length = "0x44F")]
	protected virtual void RefreshTimeRemainText(TimeSpan timeSpan)
	{
	}

	[Token(Token = "0x6005285")]
	[Address(RVA = "0x423CF0", Offset = "0x4224F0", Length = "0xE")]
	public DLCInfoActiveTime()
	{
	}
}
