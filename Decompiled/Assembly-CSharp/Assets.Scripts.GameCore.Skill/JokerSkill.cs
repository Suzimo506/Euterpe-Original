using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x74AF0", Offset = "0x73EF0")]
[Token(Token = "0x2000703")]
public class JokerSkill : ISkill
{
	[Token(Token = "0x17000611")]
	public string uid
	{
		[Token(Token = "0x60041D0")]
		[Address(RVA = "0x7CE230", Offset = "0x7CCA30", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CE1D0", Offset = "0x7CC9D0", Length = "0x59")]
	[Token(Token = "0x60041D1")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041D2")]
	public JokerSkill()
	{
	}
}
