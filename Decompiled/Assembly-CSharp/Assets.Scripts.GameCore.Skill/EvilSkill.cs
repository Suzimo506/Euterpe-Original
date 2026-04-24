using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x20006FF")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x74520", Offset = "0x73920")]
public class EvilSkill : ISkill
{
	[Token(Token = "0x1700060D")]
	public string uid
	{
		[Token(Token = "0x60041C4")]
		[Address(RVA = "0x7CDF40", Offset = "0x7CC740", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041C5")]
	[Address(RVA = "0x7CDE80", Offset = "0x7CC680", Length = "0xB5")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041C6")]
	public EvilSkill()
	{
	}
}
