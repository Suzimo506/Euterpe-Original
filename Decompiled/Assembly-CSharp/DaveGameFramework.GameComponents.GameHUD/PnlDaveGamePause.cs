using Cpp2ILInjected;
using UnityEngine;

namespace DaveGameFramework.GameComponents.GameHUD;

[Token(Token = "0x20004CF")]
public class PnlDaveGamePause : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x4001A2B")]
	[FieldOffset(Offset = "0xF0")]
	private GameObject pnl321;

	[Token(Token = "0x60035D3")]
	[Address(RVA = "0x9A1540", Offset = "0x99FD40", Length = "0x55")]
	protected override void OnCancelClicked()
	{
	}

	[Token(Token = "0x60035D4")]
	[Address(RVA = "0x9A15A0", Offset = "0x99FDA0", Length = "0x70")]
	protected override void OnNoClicked()
	{
	}

	[Token(Token = "0x60035D5")]
	[Address(RVA = "0x9A1620", Offset = "0x99FE20", Length = "0x45")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x9A1750", Offset = "0x99FF50", Length = "0xA5")]
	[Token(Token = "0x60035D6")]
	public override void Show()
	{
	}

	[Token(Token = "0x60035D7")]
	[Address(RVA = "0x9A16D0", Offset = "0x99FED0", Length = "0x7D")]
	private void ShowUpdateTip()
	{
	}

	[Token(Token = "0x60035D8")]
	[Address(RVA = "0x9A1670", Offset = "0x99FE70", Length = "0x5C")]
	private void ShowMusicInvalidTip()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60035D9")]
	public PnlDaveGamePause()
	{
	}
}
