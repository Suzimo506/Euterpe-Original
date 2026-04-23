using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x79610", Offset = "0x78A10")]
[Token(Token = "0x2000712")]
public class WisadelSkill : ISkill
{
	[Token(Token = "0x17000620")]
	public string uid
	{
		[Address(RVA = "0x7E2820", Offset = "0x7E1020", Length = "0x2B")]
		[Token(Token = "0x60041FD")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7E27D0", Offset = "0x7E0FD0", Length = "0x41")]
	[Token(Token = "0x60041FE")]
	public void Apply()
	{
	}

	[Token(Token = "0x60041FF")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public WisadelSkill()
	{
	}
}
