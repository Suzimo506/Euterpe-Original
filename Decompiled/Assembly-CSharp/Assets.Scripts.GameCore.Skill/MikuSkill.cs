using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x75020", Offset = "0x74420")]
[Token(Token = "0x2000706")]
public class MikuSkill : ISkill
{
	[Token(Token = "0x17000614")]
	public string uid
	{
		[Token(Token = "0x60041D9")]
		[Address(RVA = "0x7CE6B0", Offset = "0x7CCEB0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041DA")]
	[Address(RVA = "0x7CE660", Offset = "0x7CCE60", Length = "0x41")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041DB")]
	public MikuSkill()
	{
	}
}
