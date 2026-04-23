using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B0")]
public class GameMainPnlPause : BaseMessageBox
{
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_CanLogicInteract;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400049C")]
	private Coroutine m_Coroutine;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400049D")]
	public GameObject pnl321;

	[Token(Token = "0x14000002")]
	private event Action<string> OnPushToThinkingData
	{
		[CompilerGenerated]
		[Address(RVA = "0x5BDBA0", Offset = "0x5BC3A0", Length = "0x9E")]
		[Token(Token = "0x6000537")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x5BDC40", Offset = "0x5BC440", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x5BD420", Offset = "0x5BBC20", Length = "0xB9")]
	[Token(Token = "0x6000539")]
	protected override void OnCancelClicked()
	{
	}

	[Address(RVA = "0x5BD520", Offset = "0x5BBD20", Length = "0x11C")]
	[Token(Token = "0x600053A")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x5BD640", Offset = "0x5BBE40", Length = "0x62")]
	[Token(Token = "0x600053B")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x5BD800", Offset = "0x5BC000", Length = "0x290")]
	public override void Show()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x5BD780", Offset = "0x5BBF80", Length = "0x7D")]
	private void ShowUpdateTip()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x5BD720", Offset = "0x5BBF20", Length = "0x5C")]
	private void ShowMusicInvalidTip()
	{
	}

	[Address(RVA = "0x5BD4E0", Offset = "0x5BBCE0", Length = "0x33")]
	[Token(Token = "0x600053F")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x5BD250", Offset = "0x5BBA50", Length = "0x1CB")]
	[Token(Token = "0x6000540")]
	private void CrashDelay(string deviceModel)
	{
	}

	[Address(RVA = "0x5BD6B0", Offset = "0x5BBEB0", Length = "0x65")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x99D90", Offset = "0x99190")]
	[Token(Token = "0x6000541")]
	private IEnumerator ResetInteract()
	{
		return null;
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x5BDAA0", Offset = "0x5BC2A0", Length = "0x100")]
	public GameMainPnlPause()
	{
	}
}
