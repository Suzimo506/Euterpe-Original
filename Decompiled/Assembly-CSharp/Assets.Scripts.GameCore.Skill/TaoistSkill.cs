using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x79360", Offset = "0x78760")]
[Token(Token = "0x2000710")]
public class TaoistSkill : ISkill
{
	[Token(Token = "0x1700061E")]
	public string uid
	{
		[Address(RVA = "0x7D4320", Offset = "0x7D2B20", Length = "0x2B")]
		[Token(Token = "0x60041F7")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7D4290", Offset = "0x7D2A90", Length = "0x82")]
	[Token(Token = "0x60041F8")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041F9")]
	public TaoistSkill()
	{
	}
}
