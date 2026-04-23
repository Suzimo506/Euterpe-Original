using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x79830", Offset = "0x78C30")]
[Token(Token = "0x2000713")]
public class WorkerSkill : ISkill
{
	[Token(Token = "0x17000621")]
	public string uid
	{
		[Address(RVA = "0x7E28A0", Offset = "0x7E10A0", Length = "0x2B")]
		[Token(Token = "0x6004200")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7E2850", Offset = "0x7E1050", Length = "0x41")]
	[Token(Token = "0x6004201")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004202")]
	public WorkerSkill()
	{
	}
}
