using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000167")]
public class NewFavoriteCharacterCell : MonoBehaviour
{
	[Token(Token = "0x40008D0")]
	[FieldOffset(Offset = "0x18")]
	public Image imgCharacterHead;

	[Token(Token = "0x40008D1")]
	[FieldOffset(Offset = "0x20")]
	public Text txtCharacterName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008D2")]
	private DBConfigCharacter m_ConfigCharacter;

	[Address(RVA = "0x86A920", Offset = "0x869120", Length = "0x288")]
	[Token(Token = "0x6000A37")]
	public bool Refresh(string characterUid, int skinIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public NewFavoriteCharacterCell()
	{
	}
}
