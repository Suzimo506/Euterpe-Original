using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill.Character;

[Token(Token = "0x2000722")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B6A0", Offset = "0x7AAA0")]
public class AmiyaSkill : ISkill
{
	[Token(Token = "0x17000631")]
	public string uid
	{
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x7CCE50", Offset = "0x7CB650", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600422E")]
	[Address(RVA = "0x7CCE00", Offset = "0x7CB600", Length = "0x41")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600422F")]
	public AmiyaSkill()
	{
	}
}
