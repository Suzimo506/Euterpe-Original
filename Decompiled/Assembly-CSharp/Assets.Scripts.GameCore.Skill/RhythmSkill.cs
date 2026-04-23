using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200071E")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B170", Offset = "0x7A570")]
public class RhythmSkill : ISkill
{
	[Token(Token = "0x1700062C")]
	public string uid
	{
		[Token(Token = "0x6004221")]
		[Address(RVA = "0x7CF010", Offset = "0x7CD810", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004222")]
	[Address(RVA = "0x7CEF80", Offset = "0x7CD780", Length = "0x8C")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004223")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RhythmSkill()
	{
	}
}
