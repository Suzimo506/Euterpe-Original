using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x79B90", Offset = "0x78F90")]
[Token(Token = "0x2000715")]
public class AngelSkill : ISkill
{
	[Token(Token = "0x17000623")]
	public string uid
	{
		[Token(Token = "0x6004206")]
		[Address(RVA = "0x7CCED0", Offset = "0x7CB6D0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CCE80", Offset = "0x7CB680", Length = "0x44")]
	[Token(Token = "0x6004207")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004208")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public AngelSkill()
	{
	}
}
