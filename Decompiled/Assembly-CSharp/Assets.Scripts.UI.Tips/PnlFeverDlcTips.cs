using Assets.Scripts.Database;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x2000881")]
public class PnlFeverDlcTips : BaseMessageBox
{
	[Token(Token = "0x4002C69")]
	[FieldOffset(Offset = "0xF0")]
	private int m_ThemeIndex;

	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4002C6A")]
	private int m_JsonIndex;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4002C6B")]
	private string m_PackageName;

	[Token(Token = "0x4002C6C")]
	[FieldOffset(Offset = "0x100")]
	private DBConfigFever m_ConfigFever;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002C6D")]
	private DBConfigAlbums m_Album;

	[Address(RVA = "0x5FC900", Offset = "0x5FB100", Length = "0xA6")]
	[Token(Token = "0x6004D85")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x6004D86")]
	[Address(RVA = "0x5FCB50", Offset = "0x5FB350", Length = "0x92")]
	public override void SetSetting(string key, int value)
	{
	}

	[Address(RVA = "0x5FCBF0", Offset = "0x5FB3F0", Length = "0xD0")]
	[Token(Token = "0x6004D87")]
	public override void Show()
	{
	}

	[Token(Token = "0x6004D88")]
	[Address(RVA = "0x5FCAB0", Offset = "0x5FB2B0", Length = "0x9F")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6004D89")]
	[Address(RVA = "0x5FC9B0", Offset = "0x5FB1B0", Length = "0xF4")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x6004D8A")]
	[Address(RVA = "0x5F96A0", Offset = "0x5F7EA0", Length = "0x51")]
	public PnlFeverDlcTips()
	{
	}
}
