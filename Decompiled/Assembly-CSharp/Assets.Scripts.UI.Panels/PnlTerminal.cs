using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008DE")]
public class PnlTerminal : BaseMessageBox
{
	[Token(Token = "0x4002EF1")]
	[FieldOffset(Offset = "0xF0")]
	public Button btnVerifying;

	[SerializeField]
	[Token(Token = "0x4002EF2")]
	[FieldOffset(Offset = "0xF8")]
	private InputField m_InputField;

	[Token(Token = "0x4002EF3")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private GameObject m_ImgSelectObj;

	[Token(Token = "0x6005048")]
	[Address(RVA = "0x4C6850", Offset = "0x4C5050", Length = "0x94")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x6005049")]
	[Address(RVA = "0x4C6680", Offset = "0x4C4E80", Length = "0xA5")]
	private void OnTextChanged(string text)
	{
	}

	[Token(Token = "0x600504A")]
	[Address(RVA = "0x4C6730", Offset = "0x4C4F30", Length = "0x11B")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x600504B")]
	[Address(RVA = "0x4C6650", Offset = "0x4C4E50", Length = "0x2B")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x600504C")]
	[Address(RVA = "0x4C65E0", Offset = "0x4C4DE0", Length = "0x6E")]
	private void Callback()
	{
	}

	[Token(Token = "0x600504D")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlTerminal()
	{
	}
}
