using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Skill;

[Token(Token = "0x20006FB")]
public interface ISkill
{
	[Token(Token = "0x17000609")]
	string uid
	{
		[Token(Token = "0x60041B9")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x60041BA")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Apply();
}
