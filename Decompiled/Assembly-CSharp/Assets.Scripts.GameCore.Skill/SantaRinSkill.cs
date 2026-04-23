using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Attribute(Name = "SkillInfoAttribute", RVA = "0x75B30", Offset = "0x74F30")]
[Token(Token = "0x200070D")]
public class SantaRinSkill : ISkill
{
	[Token(Token = "0x1700061B")]
	public string uid
	{
		[Address(RVA = "0x7CF270", Offset = "0x7CDA70", Length = "0x2B")]
		[Token(Token = "0x60041EE")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CF140", Offset = "0x7CD940", Length = "0x12F")]
	[Token(Token = "0x60041EF")]
	public void Apply()
	{
	}

	[Token(Token = "0x60041F0")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public SantaRinSkill()
	{
	}
}
