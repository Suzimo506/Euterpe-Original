using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Interface;

[Token(Token = "0x2000725")]
public interface IInitialization
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004236")]
	void OnAwake();

	[Token(Token = "0x6004237")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnStart();

	[Token(Token = "0x6004238")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Destroy();
}
