using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill.Character;

[Token(Token = "0x2000723")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B850", Offset = "0x7AC50")]
internal class MarisaSkill : ISkill
{
	[Token(Token = "0x17000632")]
	public string uid
	{
		[Address(RVA = "0x7CE630", Offset = "0x7CCE30", Length = "0x2B")]
		[Token(Token = "0x6004230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004231")]
	[Address(RVA = "0x7CE5D0", Offset = "0x7CCDD0", Length = "0x56")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004232")]
	public MarisaSkill()
	{
	}
}
