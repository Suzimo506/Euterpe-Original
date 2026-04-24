using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200070A")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x756E0", Offset = "0x74AE0")]
public class ReimuSkill : ISkill
{
	[Token(Token = "0x17000618")]
	public string uid
	{
		[Address(RVA = "0x7CEF50", Offset = "0x7CD750", Length = "0x2B")]
		[Token(Token = "0x60041E5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041E6")]
	[Address(RVA = "0x7CEE60", Offset = "0x7CD660", Length = "0xED")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041E7")]
	public ReimuSkill()
	{
	}
}
