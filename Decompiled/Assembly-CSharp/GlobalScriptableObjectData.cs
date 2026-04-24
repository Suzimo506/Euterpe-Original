using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[CreateAssetMenu]
[Token(Token = "0x2000028")]
public class GlobalScriptableObjectData : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B4")]
	public Color[] gradeColor;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x20")]
	public List<ReportCardColorScheme> reportCardColorSchemes;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x28")]
	public string pnlstageDiff1SImageName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B7")]
	public string pnlstageDiff2SImageName;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000B8")]
	public string pnlstageDiff3SImageName;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000B9")]
	public Color diff1TextOutlineColor;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000BA")]
	public Color diff2TextOutlineColor;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000BB")]
	public Color diff3TextOutlineColor;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000BC")]
	public Color diff1TextColor;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000BD")]
	public Color diff2TextColor;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000BE")]
	public Color diff3TextColor;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0xA0")]
	public TMP_FontAsset cs;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0xA8")]
	public TMP_FontAsset ct;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000C1")]
	public TMP_FontAsset jp;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000C2")]
	public TMP_FontAsset kr;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0xC0")]
	public TMP_FontAsset en;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0xC8")]
	public string btnLoveOn;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000C5")]
	public string btnLoveOff;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0xD8")]
	public string btnRandomOn;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000C7")]
	public string btnRandomOff;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0xE8")]
	public string imgRandomOnName;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0xF0")]
	public string imgRandomOffName;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0xF8")]
	public string imgLockOnName;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x100")]
	public string imgLockOffName;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x108")]
	public Color colorLevelBgPink;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x118")]
	public Color colorLevelBgGrey;

	[Address(RVA = "0x5C1530", Offset = "0x5BFD30", Length = "0x1A6")]
	[Token(Token = "0x6000102")]
	public ReportCardColorScheme GetReportCardColorSchemeBySelectedIndex(int index)
	{
		return default(ReportCardColorScheme);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x5C16E0", Offset = "0x5BFEE0", Length = "0x7")]
	public GlobalScriptableObjectData()
	{
	}
}
