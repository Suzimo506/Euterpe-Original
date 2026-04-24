using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C2")]
public class PnlBlowSoundBuy : BaseMessageBox
{
	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0xF0")]
	private int targetAlbumJsonIndex;

	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40004FA")]
	private GameObject m_SoundBuyTipPMD;

	[SerializeField]
	[Token(Token = "0x40004FB")]
	[FieldOffset(Offset = "0x100")]
	private GameObject m_SoundBuyTipPC;

	[SerializeField]
	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x108")]
	private GameObject m_SoundBuyTipMP;

	[Address(RVA = "0x4FBA40", Offset = "0x4FA240", Length = "0x8")]
	[Token(Token = "0x60005A3")]
	public override void SetSetting(string key, int value)
	{
	}

	[Address(RVA = "0x4FB7B0", Offset = "0x4F9FB0", Length = "0xD9")]
	[Token(Token = "0x60005A4")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0x4FB7B0", Offset = "0x4F9FB0", Length = "0xD9")]
	private void CheckPlatform()
	{
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0x4FB890", Offset = "0x4FA090", Length = "0x1A6")]
	protected override void OnYesClicked()
	{
	}

	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	[Token(Token = "0x60005A7")]
	public PnlBlowSoundBuy()
	{
	}
}
