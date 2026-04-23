using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Nice.Interface;

[Token(Token = "0x20005E8")]
public interface IPlayable
{
	[Token(Token = "0x17000569")]
	float duration
	{
		[Token(Token = "0x6003A18")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x6003A19")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Enter();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003A1A")]
	void Execute();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003A1B")]
	void Exit();

	[Token(Token = "0x6003A1C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Pause();

	[Token(Token = "0x6003A1D")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Resume();
}
