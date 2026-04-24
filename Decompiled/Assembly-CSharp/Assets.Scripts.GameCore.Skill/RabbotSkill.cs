using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200071D")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B0E0", Offset = "0x7A4E0")]
public class RabbotSkill : ISkill
{
	[Token(Token = "0x1700062B")]
	public string uid
	{
		[Address(RVA = "0x7CED60", Offset = "0x7CD560", Length = "0x2B")]
		[Token(Token = "0x600421E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600421F")]
	[Address(RVA = "0x7CECE0", Offset = "0x7CD4E0", Length = "0x7F")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004220")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RabbotSkill()
	{
	}
}
