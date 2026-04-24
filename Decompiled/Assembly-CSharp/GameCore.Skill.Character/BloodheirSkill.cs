using Assets.Scripts.GameCore.Skill;
using Cpp2ILInjected;

namespace GameCore.Skill.Character;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x3C1F0", Offset = "0x3B5F0")]
[Token(Token = "0x2000469")]
public class BloodheirSkill : ISkill
{
	[Token(Token = "0x1700048F")]
	public string uid
	{
		[Token(Token = "0x6003302")]
		[Address(RVA = "0x8F53D0", Offset = "0x8F3BD0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003303")]
	[Address(RVA = "0x8F5380", Offset = "0x8F3B80", Length = "0x41")]
	public void Apply()
	{
	}

	[Token(Token = "0x6003304")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BloodheirSkill()
	{
	}
}
