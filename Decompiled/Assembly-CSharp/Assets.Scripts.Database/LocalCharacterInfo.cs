using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200079C")]
public class LocalCharacterInfo : BaseDataObject
{
	[Token(Token = "0x4002841")]
	[FieldOffset(Offset = "0x20")]
	public string characterName;

	[Token(Token = "0x4002842")]
	[FieldOffset(Offset = "0x28")]
	public string cosName;

	[Token(Token = "0x4002843")]
	[FieldOffset(Offset = "0x30")]
	public List<string> cosNames;

	[Token(Token = "0x4002844")]
	[FieldOffset(Offset = "0x38")]
	public string description;

	[Token(Token = "0x4002845")]
	[FieldOffset(Offset = "0x40")]
	public string skill;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002846")]
	public List<string> skills;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002847")]
	public string chipName;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002848")]
	public string chipDescription;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002849")]
	public string cv;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400284A")]
	public List<string> cvs;

	[Token(Token = "0x400284B")]
	[FieldOffset(Offset = "0x70")]
	public List<List<string>> expressions;

	[Token(Token = "0x400284C")]
	[FieldOffset(Offset = "0x78")]
	public List<List<string>> reviewExpressions;

	[Token(Token = "0x400284D")]
	[FieldOffset(Offset = "0x80")]
	public List<string> skinNames;

	[Token(Token = "0x400284E")]
	[FieldOffset(Offset = "0x88")]
	public List<List<string>> catExpressions;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400284F")]
	public List<List<string>> foolishExpressions;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002850")]
	public List<List<string>> autoExpressions;

	[Token(Token = "0x60046E2")]
	[Address(RVA = "0x49FF80", Offset = "0x49E780", Length = "0x6D")]
	public string GetSkill(int index)
	{
		return null;
	}

	[Token(Token = "0x60046E3")]
	[Address(RVA = "0x49FF10", Offset = "0x49E710", Length = "0x67")]
	public string GetCosName(int index)
	{
		return null;
	}

	[Token(Token = "0x60046E4")]
	[Address(RVA = "0x49FEA0", Offset = "0x49E6A0", Length = "0x67")]
	public string GetCV(int index)
	{
		return null;
	}

	[Token(Token = "0x60046E5")]
	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	public LocalCharacterInfo()
	{
	}
}
