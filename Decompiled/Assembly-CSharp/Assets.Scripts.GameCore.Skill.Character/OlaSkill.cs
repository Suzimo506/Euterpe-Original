using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill.Character;

[Token(Token = "0x2000724")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B960", Offset = "0x7AD60")]
public class OlaSkill : ISkill
{
	[Token(Token = "0x17000633")]
	public string uid
	{
		[Address(RVA = "0x7CE8F0", Offset = "0x7CD0F0", Length = "0x2B")]
		[Token(Token = "0x6004233")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CE890", Offset = "0x7CD090", Length = "0x59")]
	[Token(Token = "0x6004234")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004235")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public OlaSkill()
	{
	}
}
