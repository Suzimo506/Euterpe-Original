using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x79EB0", Offset = "0x792B0")]
[Token(Token = "0x2000717")]
public class DragonGirlSkill : ISkill
{
	[Token(Token = "0x17000625")]
	public string uid
	{
		[Address(RVA = "0x7CDE50", Offset = "0x7CC650", Length = "0x2B")]
		[Token(Token = "0x600420C")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CDE00", Offset = "0x7CC600", Length = "0x44")]
	[Token(Token = "0x600420D")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600420E")]
	public DragonGirlSkill()
	{
	}
}
