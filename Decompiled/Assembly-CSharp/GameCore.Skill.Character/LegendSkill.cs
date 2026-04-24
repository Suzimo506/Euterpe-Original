using Assets.Scripts.GameCore.Skill;
using Cpp2ILInjected;

namespace GameCore.Skill.Character;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x3C390", Offset = "0x3B790")]
[Token(Token = "0x200046C")]
public class LegendSkill : ISkill
{
	[Token(Token = "0x17000492")]
	public string uid
	{
		[Address(RVA = "0x90A3B0", Offset = "0x908BB0", Length = "0x2B")]
		[Token(Token = "0x600330B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x90A320", Offset = "0x908B20", Length = "0x8C")]
	[Token(Token = "0x600330C")]
	public void Apply()
	{
	}

	[Token(Token = "0x600330D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public LegendSkill()
	{
	}
}
