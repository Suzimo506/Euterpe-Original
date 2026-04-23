using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000191")]
public class PnlStageIcon : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009D8")]
	private Image m_Image;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009D9")]
	private Sprite m_Sprite;

	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x28")]
	private Text m_Title;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009DB")]
	private Color m_TitleColor;

	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x40")]
	private Color m_BgColor;

	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsLock;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009DE")]
	public Sprite iconLock;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40009DF")]
	public Sprite iconWeekFree;

	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlStageIcon()
	{
	}
}
