using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000168")]
public class NewPassMusicCell : MonoBehaviour
{
	[Token(Token = "0x40008D3")]
	[FieldOffset(Offset = "0x18")]
	public Image imgCover;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008D4")]
	public List<GameObject> starObjs;

	[Token(Token = "0x40008D5")]
	[FieldOffset(Offset = "0x28")]
	public List<Text> starTxtValues;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008D6")]
	public LongSongNameController longSongNameController;

	[Token(Token = "0x40008D7")]
	[FieldOffset(Offset = "0x38")]
	public Text txtGrade;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008D8")]
	private GlobalScriptableObjectData globalData;

	[Token(Token = "0x6000A39")]
	[Address(RVA = "0x86ABB0", Offset = "0x8693B0", Length = "0x440")]
	public bool Refresh(string musicUid, int evaluate, int resultIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0x86B000", Offset = "0x869800", Length = "0x96")]
	public NewPassMusicCell()
	{
	}
}
