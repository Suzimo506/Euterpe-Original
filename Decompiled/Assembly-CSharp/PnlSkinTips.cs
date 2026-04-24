using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000CB")]
public class PnlSkinTips : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000505")]
	private int m_JsonIndex;

	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private GameObject m_TxtNoCharacterObj;

	[Address(RVA = "0x563190", Offset = "0x561990", Length = "0x169")]
	[Token(Token = "0x60005C2")]
	public void ShowSkinTip(int jsonIndex, int characterIndex, bool hasGotRole)
	{
	}

	[Address(RVA = "0x563130", Offset = "0x561930", Length = "0x60")]
	[Token(Token = "0x60005C3")]
	protected override void OnYesClicked()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlSkinTips()
	{
	}
}
