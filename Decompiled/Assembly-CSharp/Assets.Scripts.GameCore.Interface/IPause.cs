using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Interface;

[Token(Token = "0x2000727")]
public interface IPause
{
	[Token(Token = "0x17000636")]
	bool IsGlobal
	{
		[Token(Token = "0x600423E")]
		[Address(RVA = "0x0", Length = "0x0")]
		get;
	}

	[Token(Token = "0x600423C")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Pause(bool pauseCorountine);

	[Token(Token = "0x600423D")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Resume();
}
