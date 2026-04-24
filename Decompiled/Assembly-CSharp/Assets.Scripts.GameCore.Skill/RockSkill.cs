using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x75980", Offset = "0x74D80")]
[Token(Token = "0x200070C")]
public class RockSkill : ISkill
{
	[Token(Token = "0x1700061A")]
	public string uid
	{
		[Address(RVA = "0x7CF110", Offset = "0x7CD910", Length = "0x2B")]
		[Token(Token = "0x60041EB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60041EC")]
	[Address(RVA = "0x7CF0C0", Offset = "0x7CD8C0", Length = "0x41")]
	public void Apply()
	{
	}

	[Token(Token = "0x60041ED")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RockSkill()
	{
	}
}
