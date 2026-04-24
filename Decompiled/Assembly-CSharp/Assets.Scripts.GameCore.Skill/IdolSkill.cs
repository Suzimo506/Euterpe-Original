using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x747C0", Offset = "0x73BC0")]
[Token(Token = "0x2000701")]
public class IdolSkill : ISkill
{
	[Token(Token = "0x1700060F")]
	public string uid
	{
		[Address(RVA = "0x7CE0F0", Offset = "0x7CC8F0", Length = "0x2B")]
		[Token(Token = "0x60041CA")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CE080", Offset = "0x7CC880", Length = "0x64")]
	[Token(Token = "0x60041CB")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041CC")]
	public IdolSkill()
	{
	}
}
