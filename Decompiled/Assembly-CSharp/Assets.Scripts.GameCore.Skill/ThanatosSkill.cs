using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200071F")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B2E0", Offset = "0x7A6E0")]
public class ThanatosSkill : ISkill
{
	[Token(Token = "0x1700062D")]
	public string uid
	{
		[Token(Token = "0x6004224")]
		[Address(RVA = "0x7DB360", Offset = "0x7D9B60", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004225")]
	[Address(RVA = "0x7DB2E0", Offset = "0x7D9AE0", Length = "0x7E")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004226")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ThanatosSkill()
	{
	}
}
