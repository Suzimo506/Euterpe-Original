using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x799A0", Offset = "0x78DA0")]
[Token(Token = "0x2000714")]
public class ZombieSkill : ISkill
{
	[Token(Token = "0x17000622")]
	public string uid
	{
		[Address(RVA = "0x7E2940", Offset = "0x7E1140", Length = "0x2B")]
		[Token(Token = "0x6004203")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7E28D0", Offset = "0x7E10D0", Length = "0x6E")]
	[Token(Token = "0x6004204")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004205")]
	public ZombieSkill()
	{
	}
}
