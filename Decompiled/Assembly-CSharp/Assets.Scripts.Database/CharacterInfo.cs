using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x200079D")]
public class CharacterInfo : BaseDataObject
{
	[Token(Token = "0x4002851")]
	[FieldOffset(Offset = "0x20")]
	public string characterName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002852")]
	public string cosName;

	[Token(Token = "0x4002853")]
	[FieldOffset(Offset = "0x30")]
	public string description;

	[Token(Token = "0x4002854")]
	[FieldOffset(Offset = "0x38")]
	public string defaultHP;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002855")]
	public string skillName;

	[Token(Token = "0x4002856")]
	[FieldOffset(Offset = "0x48")]
	public string skill;

	[Token(Token = "0x4002857")]
	[FieldOffset(Offset = "0x50")]
	public string chipName;

	[Token(Token = "0x4002858")]
	[FieldOffset(Offset = "0x58")]
	public string chipDescription;

	[Token(Token = "0x4002859")]
	[FieldOffset(Offset = "0x60")]
	public string cv;

	[Token(Token = "0x400285A")]
	[FieldOffset(Offset = "0x68")]
	public int chipAmount;

	[Token(Token = "0x400285B")]
	[FieldOffset(Offset = "0x70")]
	public string chipImage;

	[Token(Token = "0x400285C")]
	[FieldOffset(Offset = "0x78")]
	public string mainShow;

	[Token(Token = "0x400285D")]
	[FieldOffset(Offset = "0x80")]
	public string battleShow;

	[Token(Token = "0x400285E")]
	[FieldOffset(Offset = "0x88")]
	public string feverShow;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400285F")]
	public string atkFxGreat;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002860")]
	public string atkFxPerfect;

	[Token(Token = "0x4002861")]
	[FieldOffset(Offset = "0xA0")]
	public string atkFxCrit;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4002862")]
	public string jumpFxDust;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4002863")]
	public string victoryShow;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002864")]
	public string failShow;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002865")]
	public string bgm;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002866")]
	public int unlockType;

	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4002867")]
	public int unlockCount;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002868")]
	public string rarity;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002869")]
	public bool free;

	[FieldOffset(Offset = "0xD9")]
	[Token(Token = "0x400286A")]
	public bool hide;

	[FieldOffset(Offset = "0xDA")]
	[Token(Token = "0x400286B")]
	public bool egg;

	[FieldOffset(Offset = "0xDB")]
	[Token(Token = "0x400286C")]
	public bool exchange;

	[Token(Token = "0x400286D")]
	[FieldOffset(Offset = "0xDC")]
	public bool special;

	[Token(Token = "0x400286E")]
	[FieldOffset(Offset = "0xE0")]
	public string characterType;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400286F")]
	public string releasedVersion;

	[Token(Token = "0x4002870")]
	[FieldOffset(Offset = "0xF0")]
	public int order;

	[Token(Token = "0x4002871")]
	[FieldOffset(Offset = "0xF8")]
	public List<RoleSkin> skins;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4002872")]
	public List<Expression> expressions;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002873")]
	public List<Expression> reviewExpressions;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4002874")]
	public List<Expression> catExpressions;

	[Token(Token = "0x4002875")]
	[FieldOffset(Offset = "0x118")]
	public List<Expression> foolishExpressions;

	[Token(Token = "0x4002876")]
	[FieldOffset(Offset = "0x120")]
	public List<Expression> autoExpressions;

	[Token(Token = "0x60046E6")]
	[Address(RVA = "0x6F2AE0", Offset = "0x6F12E0", Length = "0x16A")]
	public RoleSkin GetSkin(int skinIndex)
	{
		return null;
	}

	[Address(RVA = "0x6F2C50", Offset = "0x6F1450", Length = "0xD1")]
	[Token(Token = "0x60046E7")]
	private void SetExpression(List<Expression> expr, List<List<string>> localExpr)
	{
	}

	[Token(Token = "0x60046E8")]
	[Address(RVA = "0x6F2250", Offset = "0x6F0A50", Length = "0x1F8")]
	public List<Expression> GetAutoExpressions()
	{
		return null;
	}

	[Token(Token = "0x60046E9")]
	[Address(RVA = "0x6F2450", Offset = "0x6F0C50", Length = "0x68F")]
	public List<Expression> GetExpression()
	{
		return null;
	}

	[Token(Token = "0x60046EA")]
	[Address(RVA = "0x6EF370", Offset = "0x6EDB70", Length = "0x69")]
	public CharacterInfo()
	{
	}
}
