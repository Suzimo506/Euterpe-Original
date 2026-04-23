using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x200070E")]
[Attribute(Name = "SkillInfoAttribute", RVA = "0x791F0", Offset = "0x785F0")]
public class SisterSkill : ISkill
{
	[Token(Token = "0x1700061C")]
	public string uid
	{
		[Address(RVA = "0x7CF320", Offset = "0x7CDB20", Length = "0x2B")]
		[Token(Token = "0x60041F1")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7CF2D0", Offset = "0x7CDAD0", Length = "0x41")]
	[Token(Token = "0x60041F2")]
	public void Apply()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60041F3")]
	public SisterSkill()
	{
	}
}
