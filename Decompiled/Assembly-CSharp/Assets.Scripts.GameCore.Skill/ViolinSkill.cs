using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x794E0", Offset = "0x788E0")]
[Token(Token = "0x2000711")]
public class ViolinSkill : ISkill
{
	[Token(Token = "0x1700061F")]
	public string uid
	{
		[Address(RVA = "0x7DFBB0", Offset = "0x7DE3B0", Length = "0x2B")]
		[Token(Token = "0x60041FA")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7DFB50", Offset = "0x7DE350", Length = "0x59")]
	[Token(Token = "0x60041FB")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041FC")]
	public ViolinSkill()
	{
	}
}
