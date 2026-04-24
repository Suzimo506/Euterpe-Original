using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x7A460", Offset = "0x79860")]
[Token(Token = "0x200071B")]
public class MioSirSkill : ISkill
{
	[Token(Token = "0x17000629")]
	public string uid
	{
		[Token(Token = "0x6004218")]
		[Address(RVA = "0x7CE730", Offset = "0x7CCF30", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004219")]
	[Address(RVA = "0x7CE6E0", Offset = "0x7CCEE0", Length = "0x44")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600421A")]
	public MioSirSkill()
	{
	}
}
