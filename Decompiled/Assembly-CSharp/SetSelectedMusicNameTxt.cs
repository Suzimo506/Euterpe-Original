using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000194")]
public class SetSelectedMusicNameTxt : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009EF")]
	public Text txt;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009F0")]
	public bool isMusicName;

	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x21")]
	public bool isMusicAuthor;

	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x28")]
	private LongSongNameController m_LongCtrl;

	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x62D7C0", Offset = "0x62BFC0", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x62DAB0", Offset = "0x62C2B0", Length = "0x346")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x62D960", Offset = "0x62C160", Length = "0x146")]
	private string GetSelectedMusicName(out bool isSpecialFont)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isSpecialFont) = null;
		return null;
	}

	[Address(RVA = "0x62D810", Offset = "0x62C010", Length = "0x142")]
	[Token(Token = "0x6000B71")]
	private string GetSelectedMusicAuthor()
	{
		return null;
	}

	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public SetSelectedMusicNameTxt()
	{
	}
}
