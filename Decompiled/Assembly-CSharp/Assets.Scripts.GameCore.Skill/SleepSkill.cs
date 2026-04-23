using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200070F")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x792E0", Offset = "0x786E0")]
public class SleepSkill : ISkill
{
	[Token(Token = "0x1700061D")]
	public string uid
	{
		[Address(RVA = "0x7CF460", Offset = "0x7CDC60", Length = "0x2B")]
		[Token(Token = "0x60041F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041F5")]
	[Address(RVA = "0x7CF390", Offset = "0x7CDB90", Length = "0xC9")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041F6")]
	public SleepSkill()
	{
	}
}
