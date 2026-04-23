using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x2000709")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x755C0", Offset = "0x749C0")]
public class RampageSkill : ISkill
{
	[Token(Token = "0x17000617")]
	public string uid
	{
		[Token(Token = "0x60041E2")]
		[Address(RVA = "0x7CEE30", Offset = "0x7CD630", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041E3")]
	[Address(RVA = "0x7CED90", Offset = "0x7CD590", Length = "0x97")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041E4")]
	public RampageSkill()
	{
	}
}
