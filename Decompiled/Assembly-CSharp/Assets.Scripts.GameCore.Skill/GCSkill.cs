using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000700")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x746F0", Offset = "0x73AF0")]
public class GCSkill : ISkill
{
	[Token(Token = "0x1700060E")]
	public string uid
	{
		[Token(Token = "0x60041C7")]
		[Address(RVA = "0x7CE050", Offset = "0x7CC850", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041C8")]
	[Address(RVA = "0x7CDFF0", Offset = "0x7CC7F0", Length = "0x59")]
	public void Apply()
	{
	}

	[Token(Token = "0x60041C9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public GCSkill()
	{
	}
}
