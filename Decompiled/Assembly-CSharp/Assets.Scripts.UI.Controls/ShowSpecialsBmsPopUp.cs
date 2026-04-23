using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008AF")]
public class ShowSpecialsBmsPopUp : BaseMessageBox
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002D63")]
	private Color m_DefTextColor;

	[Token(Token = "0x6004E9A")]
	[Address(RVA = "0x5B7340", Offset = "0x5B5B40", Length = "0x4A")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x5B7390", Offset = "0x5B5B90", Length = "0xE7")]
	[Token(Token = "0x6004E9B")]
	public void Show(string info, MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6004E9C")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public ShowSpecialsBmsPopUp()
	{
	}
}
