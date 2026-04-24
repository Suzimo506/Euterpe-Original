using Assets.Scripts.GameCore.Skill;
using Cpp2ILInjected;

namespace GameCore.Skill.Character;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x3C310", Offset = "0x3B710")]
[Token(Token = "0x200046B")]
public class DiverSkill : ISkill
{
	[Token(Token = "0x17000491")]
	public string uid
	{
		[Token(Token = "0x6003308")]
		[Address(RVA = "0x8F5580", Offset = "0x8F3D80", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x8F5530", Offset = "0x8F3D30", Length = "0x41")]
	[Token(Token = "0x6003309")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600330A")]
	public DiverSkill()
	{
	}
}
