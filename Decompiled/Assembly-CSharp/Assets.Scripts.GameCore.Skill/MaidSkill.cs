using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000705")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x74EB0", Offset = "0x742B0")]
public class MaidSkill : ISkill
{
	[Token(Token = "0x17000613")]
	public string uid
	{
		[Address(RVA = "0x7CE5A0", Offset = "0x7CCDA0", Length = "0x2B")]
		[Token(Token = "0x60041D6")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CE4B0", Offset = "0x7CCCB0", Length = "0xE7")]
	[Token(Token = "0x60041D7")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041D8")]
	public MaidSkill()
	{
	}
}
