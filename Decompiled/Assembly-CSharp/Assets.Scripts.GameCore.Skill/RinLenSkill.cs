using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x758E0", Offset = "0x74CE0")]
[Token(Token = "0x200070B")]
public class RinLenSkill : ISkill
{
	[Token(Token = "0x17000619")]
	public string uid
	{
		[Address(RVA = "0x7CF090", Offset = "0x7CD890", Length = "0x2B")]
		[Token(Token = "0x60041E8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CF040", Offset = "0x7CD840", Length = "0x41")]
	[Token(Token = "0x60041E9")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041EA")]
	public RinLenSkill()
	{
	}
}
