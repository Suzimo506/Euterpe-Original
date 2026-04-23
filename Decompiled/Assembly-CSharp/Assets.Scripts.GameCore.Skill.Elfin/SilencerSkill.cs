using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill.Elfin;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x7B550", Offset = "0x7A950")]
[Token(Token = "0x2000721")]
internal class SilencerSkill : ISkill
{
	[Token(Token = "0x17000630")]
	public string uid
	{
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x7CF2A0", Offset = "0x7CDAA0", Length = "0x2B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600422B")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x600422C")]
	public SilencerSkill()
	{
	}
}
