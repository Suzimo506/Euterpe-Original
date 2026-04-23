using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x75380", Offset = "0x74780")]
[Token(Token = "0x2000708")]
public class PilotSkill : ISkill
{
	[Token(Token = "0x17000616")]
	public string uid
	{
		[Address(RVA = "0x7CE980", Offset = "0x7CD180", Length = "0x2B")]
		[Token(Token = "0x60041DF")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CE920", Offset = "0x7CD120", Length = "0x59")]
	[Token(Token = "0x60041E0")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041E1")]
	public PilotSkill()
	{
	}
}
