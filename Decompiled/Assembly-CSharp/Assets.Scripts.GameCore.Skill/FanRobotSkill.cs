using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000718")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x79F60", Offset = "0x79360")]
public class FanRobotSkill : ISkill
{
	[Token(Token = "0x17000626")]
	public string uid
	{
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x7CDFC0", Offset = "0x7CC7C0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CDF70", Offset = "0x7CC770", Length = "0x44")]
	[Token(Token = "0x6004210")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004211")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FanRobotSkill()
	{
	}
}
