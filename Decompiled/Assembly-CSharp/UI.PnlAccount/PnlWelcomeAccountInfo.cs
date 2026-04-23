using System.Collections.Generic;
using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using MEC;
using UnityEngine;
using UnityEngine.UI;

namespace UI.PnlAccount;

[Token(Token = "0x20001BB")]
public class PnlWelcomeAccountInfo : BasePopup<AccountCanvas>
{
	[SerializeField]
	[Token(Token = "0x4000AC0")]
	[FieldOffset(Offset = "0x108")]
	private Button m_BtnLogout;

	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private Button m_CopyUid;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000AC2")]
	[SerializeField]
	private Button m_BtnFeedback;

	[Token(Token = "0x4000AC3")]
	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	private Text m_TxtNickname;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000AC4")]
	[SerializeField]
	private Text m_TxtAccountStr;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private Text m_TxtLevel;

	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x138")]
	private AccountCanvas m_ParentCanvas;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x140")]
	private AccountDataModel m_DataModel;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000AC8")]
	private CoroutineHandle m_GetInfoCoroutine;

	[Address(RVA = "0x4DD060", Offset = "0x4DB860", Length = "0xFD")]
	[Token(Token = "0x6000C54")]
	protected override void RendDatasToUI()
	{
	}

	[Address(RVA = "0x4DCE30", Offset = "0x4DB630", Length = "0x1A1")]
	[Token(Token = "0x6000C55")]
	protected override void RegistClickEvts()
	{
	}

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x4DCFE0", Offset = "0x4DB7E0", Length = "0x70")]
	private void RemoveAllListeners()
	{
	}

	[Address(RVA = "0x4DCAD0", Offset = "0x4DB2D0", Length = "0x65")]
	[Token(Token = "0x6000C57")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x4CA80", Offset = "0x4BE80")]
	private IEnumerator<float> GetUserInfo()
	{
		return null;
	}

	[Address(RVA = "0x4DCC50", Offset = "0x4DB450", Length = "0x7")]
	[Token(Token = "0x6000C58")]
	private void OnFeedback()
	{
	}

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x4DCC40", Offset = "0x4DB440", Length = "0xD")]
	private void OnExit()
	{
	}

	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x4DCB50", Offset = "0x4DB350", Length = "0x8F")]
	private void OnCopyUid()
	{
	}

	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x4DCB40", Offset = "0x4DB340", Length = "0x7")]
	private void OnClickToAskLogout()
	{
	}

	[Address(RVA = "0x4DCC60", Offset = "0x4DB460", Length = "0x1C3")]
	[Token(Token = "0x6000C5C")]
	private void OnLogout()
	{
	}

	[Address(RVA = "0x4DCBE0", Offset = "0x4DB3E0", Length = "0x56")]
	[Token(Token = "0x6000C5D")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x4DD160", Offset = "0x4DB960", Length = "0x38")]
	public PnlWelcomeAccountInfo()
	{
		((BasePopup<>)(object)this)._002Ector();
	}
}
