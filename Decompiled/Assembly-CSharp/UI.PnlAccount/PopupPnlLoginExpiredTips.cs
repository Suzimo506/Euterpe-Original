using Assets.Scripts.UI.Abstracts;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace UI.PnlAccount;

[Token(Token = "0x20001BF")]
public class PopupPnlLoginExpiredTips : BasePopup<AccountCanvas>
{
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000AFE")]
	private Button m_BtnConfirm;

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x4E0D60", Offset = "0x4DF560", Length = "0x8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x4E0B80", Offset = "0x4DF380", Length = "0x1DC")]
	public void Show()
	{
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x4E0AA0", Offset = "0x4DF2A0", Length = "0xD7")]
	private void OnYesClicked()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000C92")]
	protected override void RendDatasToUI()
	{
	}

	[Address(RVA = "0x4E0DF0", Offset = "0x4DF5F0", Length = "0x38")]
	[Token(Token = "0x6000C93")]
	public PopupPnlLoginExpiredTips()
	{
		((BasePopup<>)(object)this)._002Ector();
	}
}
