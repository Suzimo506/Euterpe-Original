using Assets.Scripts.GameCore.Skill;
using Cpp2ILInjected;

namespace GameCore.Skill.Character;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x3C4E0", Offset = "0x3B8E0")]
[Token(Token = "0x200046D")]
public class PirateSkill : ISkill
{
	[Token(Token = "0x17000493")]
	public string uid
	{
		[Address(RVA = "0x90B040", Offset = "0x909840", Length = "0x2B")]
		[Token(Token = "0x600330E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600330F")]
	[Address(RVA = "0x90AFF0", Offset = "0x9097F0", Length = "0x41")]
	public void Apply()
	{
	}

	[Token(Token = "0x6003310")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public PirateSkill()
	{
	}
}
