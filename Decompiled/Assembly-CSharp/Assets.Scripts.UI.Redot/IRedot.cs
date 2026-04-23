using Cpp2ILInjected;

namespace Assets.Scripts.UI.Redot;

[Token(Token = "0x200084C")]
public interface IRedot
{
	[Token(Token = "0x1700085D")]
	bool Result
	{
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x0", Length = "0x0")]
		set;
	}

	[Token(Token = "0x1700085E")]
	string RedotId
	{
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x1700085F")]
	string ParentRedotId
	{
		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x6004C3C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void InitRedot(string redotId, string parentRedotId);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004C3D")]
	void UpdateRedotState();
}
