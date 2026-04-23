using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x20006FC")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x73F80", Offset = "0x73380")]
public class BlackSkill : ISkill
{
	[Token(Token = "0x1700060A")]
	public string uid
	{
		[Token(Token = "0x60041BB")]
		[Address(RVA = "0x7CD090", Offset = "0x7CB890", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041BC")]
	[Address(RVA = "0x7CCF80", Offset = "0x7CB780", Length = "0x105")]
	public void Apply()
	{
	}

	[Token(Token = "0x60041BD")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BlackSkill()
	{
	}
}
