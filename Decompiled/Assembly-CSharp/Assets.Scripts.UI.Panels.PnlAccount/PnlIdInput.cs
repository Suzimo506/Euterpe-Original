using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlAccount;

[Token(Token = "0x200090A")]
public class PnlIdInput : BaseMessageBox
{
	[Token(Token = "0x400308F")]
	[FieldOffset(Offset = "0xF0")]
	public PeroInputField inputField;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4003090")]
	public Button btnVerifying;

	[Address(RVA = "0x6CD180", Offset = "0x6CB980", Length = "0x39")]
	[Token(Token = "0x600521B")]
	private void SetVerifyingEnable(bool enable)
	{
	}

	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	[Token(Token = "0x600521C")]
	protected override void OnNoClicked()
	{
	}

	[Address(RVA = "0x6CCF10", Offset = "0x6CB710", Length = "0x267")]
	[Token(Token = "0x600521D")]
	private void OnOkClicked()
	{
	}

	[Address(RVA = "0x6CD1C0", Offset = "0x6CB9C0", Length = "0x1D2")]
	[Token(Token = "0x600521E")]
	public override void StartInit()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x600521F")]
	public PnlIdInput()
	{
	}
}
