using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x74D30", Offset = "0x74130")]
[Token(Token = "0x2000704")]
public class MagicSkill : ISkill
{
	[Token(Token = "0x17000612")]
	public string uid
	{
		[Token(Token = "0x60041D3")]
		[Address(RVA = "0x7CE480", Offset = "0x7CCC80", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CE420", Offset = "0x7CCC20", Length = "0x5C")]
	[Token(Token = "0x60041D4")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041D5")]
	public MagicSkill()
	{
	}
}
