using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x7A2B0", Offset = "0x796B0")]
[Token(Token = "0x200071A")]
public class MagicGirlSkill : ISkill
{
	[Token(Token = "0x17000628")]
	public string uid
	{
		[Address(RVA = "0x7CE3F0", Offset = "0x7CCBF0", Length = "0x2B")]
		[Token(Token = "0x6004215")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004216")]
	[Address(RVA = "0x7CE3A0", Offset = "0x7CCBA0", Length = "0x44")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004217")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public MagicGirlSkill()
	{
	}
}
