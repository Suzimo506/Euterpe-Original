using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200071C")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7A6D0", Offset = "0x79AD0")]
public class NeonEggSkill : ISkill
{
	[Token(Token = "0x1700062A")]
	public string uid
	{
		[Token(Token = "0x600421B")]
		[Address(RVA = "0x7CE860", Offset = "0x7CD060", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600421C")]
	[Address(RVA = "0x7CE7E0", Offset = "0x7CCFE0", Length = "0x73")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600421D")]
	public NeonEggSkill()
	{
	}
}
