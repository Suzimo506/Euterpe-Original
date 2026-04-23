using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x20006FD")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x741F0", Offset = "0x735F0")]
public class BunnySkill : ISkill
{
	[Token(Token = "0x1700060B")]
	public string uid
	{
		[Address(RVA = "0x7CD170", Offset = "0x7CB970", Length = "0x2B")]
		[Token(Token = "0x60041BE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041BF")]
	[Address(RVA = "0x7CD0C0", Offset = "0x7CB8C0", Length = "0xA1")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041C0")]
	public BunnySkill()
	{
	}
}
