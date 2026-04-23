using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x752C0", Offset = "0x746C0")]
[Token(Token = "0x2000707")]
public class NekoSkill : ISkill
{
	[Token(Token = "0x17000615")]
	public string uid
	{
		[Address(RVA = "0x7CE7B0", Offset = "0x7CCFB0", Length = "0x2B")]
		[Token(Token = "0x60041DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041DD")]
	[Address(RVA = "0x7CE760", Offset = "0x7CCF60", Length = "0x41")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041DE")]
	public NekoSkill()
	{
	}
}
