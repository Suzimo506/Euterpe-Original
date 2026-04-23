using System.Collections.Generic;
using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using PeroTools2.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.PnlAccount;

[Token(Token = "0x20001C0")]
public class PopupPnlPermissions : BasePopup<AccountCanvas>
{
	[Token(Token = "0x4000AFF")]
	[SerializeField]
	[FieldOffset(Offset = "0x108")]
	private ClickableText m_ClickText;

	[SerializeField]
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000B00")]
	private TextMeshProUGUI m_TxtPermissions;

	[SerializeField]
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000B01")]
	private Button m_BtnCopy;

	[Token(Token = "0x4000B02")]
	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	private Button m_BtnYes;

	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000B03")]
	private Dictionary<int, string> m_StatusToTipsMapping;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000B04")]
	private string prePermissionViolations;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000B05")]
	private string curPermissionViolations;

	[Token(Token = "0x4000B06")]
	[FieldOffset(Offset = "0x140")]
	private bool m_IsLoginBan;

	[Token(Token = "0x4000B07")]
	[FieldOffset(Offset = "0x141")]
	private bool m_IsDeviceFreezeBan;

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x4E1D30", Offset = "0x4E0530", Length = "0x166")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x4E13F0", Offset = "0x4DFBF0", Length = "0xDA")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x4E1310", Offset = "0x4DFB10", Length = "0xDA")]
	[Token(Token = "0x6000C96")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4E1240", Offset = "0x4DFA40", Length = "0xCB")]
	[Token(Token = "0x6000C97")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x4E18D0", Offset = "0x4E00D0", Length = "0x454")]
	public void Show(bool isOnlyDevice, bool forceShow)
	{
	}

	[Address(RVA = "0x4E1890", Offset = "0x4E0090", Length = "0x3F")]
	[Token(Token = "0x6000C99")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x4E0E30", Offset = "0x4DF630", Length = "0x200")]
	private void AddPermissionViolations(List<int> permissionViolations, string checkType, ref string txt, bool condition)
	{
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x4E11D0", Offset = "0x4DF9D0", Length = "0x60")]
	private void OnCopyClicked()
	{
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x4E1540", Offset = "0x4DFD40", Length = "0x341")]
	private void OnYesClicked()
	{
	}

	[Address(RVA = "0x4E1040", Offset = "0x4DF840", Length = "0x180")]
	[Token(Token = "0x6000C9D")]
	private void BackToWelcome()
	{
	}

	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x4E14D0", Offset = "0x4DFCD0", Length = "0x68")]
	private void OnLinkTxtClick(string linkId, string linkInfo)
	{
	}

	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected override void RendDatasToUI()
	{
	}

	[Address(RVA = "0x4E1EA0", Offset = "0x4E06A0", Length = "0x38")]
	[Token(Token = "0x6000CA0")]
	public PopupPnlPermissions()
	{
		((BasePopup<>)(object)this)._002Ector();
	}
}
