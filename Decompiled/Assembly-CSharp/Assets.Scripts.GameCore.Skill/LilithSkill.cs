using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x7A170", Offset = "0x79570")]
[Token(Token = "0x2000719")]
public class LilithSkill : ISkill
{
	[Token(Token = "0x17000627")]
	public string uid
	{
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x7CE370", Offset = "0x7CCB70", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004213")]
	[Address(RVA = "0x7CE260", Offset = "0x7CCA60", Length = "0x109")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004214")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public LilithSkill()
	{
	}
}
