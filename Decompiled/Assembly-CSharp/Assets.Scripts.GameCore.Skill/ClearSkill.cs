using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x20006FE")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x74350", Offset = "0x73750")]
public class ClearSkill : ISkill
{
	[Token(Token = "0x1700060C")]
	public string uid
	{
		[Address(RVA = "0x7CDDD0", Offset = "0x7CC5D0", Length = "0x2B")]
		[Token(Token = "0x60041C1")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CDD80", Offset = "0x7CC580", Length = "0x41")]
	[Token(Token = "0x60041C2")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041C3")]
	public ClearSkill()
	{
	}
}
