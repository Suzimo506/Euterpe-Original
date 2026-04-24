using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000702")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x74A20", Offset = "0x73E20")]
public class JKSkill : ISkill
{
	[Token(Token = "0x17000610")]
	public string uid
	{
		[Token(Token = "0x60041CD")]
		[Address(RVA = "0x7CE1A0", Offset = "0x7CC9A0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041CE")]
	[Address(RVA = "0x7CE120", Offset = "0x7CC920", Length = "0x74")]
	public void Apply()
	{
	}

	[Token(Token = "0x60041CF")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public JKSkill()
	{
	}
}
