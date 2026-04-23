using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000188")]
public class MusicButtonAreaTitle : MonoBehaviour
{
	[Token(Token = "0x40009A1")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Text m_Txt;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009A2")]
	private LongSongNameController m_LongName;

	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009A4")]
	private bool m_IsSpecialFont;

	[Token(Token = "0x170000DC")]
	public string title
	{
		[Address(RVA = "0x8C5CA0", Offset = "0x8C44A0", Length = "0x27")]
		[Token(Token = "0x6000B21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B22")]
	[Address(RVA = "0x8C5C10", Offset = "0x8C4410", Length = "0x8E")]
	public void RefreshTxt(string title, bool isSpecialFont = false)
	{
	}

	[Token(Token = "0x6000B23")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MusicButtonAreaTitle()
	{
	}
}
