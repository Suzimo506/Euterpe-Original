using Assets.Scripts.GameCore.Skill;
using Cpp2ILInjected;

namespace GameCore.Skill.Character;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x3C290", Offset = "0x3B690")]
[Token(Token = "0x200046A")]
public class DancerSkill : ISkill
{
	[Token(Token = "0x17000490")]
	public string uid
	{
		[Address(RVA = "0x8F5450", Offset = "0x8F3C50", Length = "0x2B")]
		[Token(Token = "0x6003305")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003306")]
	[Address(RVA = "0x8F5400", Offset = "0x8F3C00", Length = "0x41")]
	public void Apply()
	{
	}

	[Token(Token = "0x6003307")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public DancerSkill()
	{
	}
}
