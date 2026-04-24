using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000716")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x79C70", Offset = "0x79070")]
public class BetaDogSkill : ISkill
{
	[Token(Token = "0x17000624")]
	public string uid
	{
		[Address(RVA = "0x7CCF50", Offset = "0x7CB750", Length = "0x2B")]
		[Token(Token = "0x6004209")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CCF00", Offset = "0x7CB700", Length = "0x4C")]
	[Token(Token = "0x600420A")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600420B")]
	public BetaDogSkill()
	{
	}
}
