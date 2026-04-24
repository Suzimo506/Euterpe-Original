using Assets.Scripts.GameCore.Skill;
using Cpp2ILInjected;

namespace GameCore.Skill.Character;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x3C560", Offset = "0x3B960")]
[Token(Token = "0x200046E")]
public class RacerSkill : ISkill
{
	[Token(Token = "0x17000494")]
	public string uid
	{
		[Address(RVA = "0x90CBC0", Offset = "0x90B3C0", Length = "0x2B")]
		[Token(Token = "0x6003311")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x90CB70", Offset = "0x90B370", Length = "0x41")]
	[Token(Token = "0x6003312")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003313")]
	public RacerSkill()
	{
	}
}
