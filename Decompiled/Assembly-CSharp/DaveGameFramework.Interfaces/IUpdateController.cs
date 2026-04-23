using Cpp2ILInjected;

namespace DaveGameFramework.Interfaces;

[Token(Token = "0x20004BB")]
public interface IUpdateController
{
	[Token(Token = "0x6003567")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnUpdate();

	[Token(Token = "0x6003568")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnFixedUpdate();

	[Token(Token = "0x6003569")]
	[Address(RVA = "0x0", Length = "0x0")]
	void OnLateUpdate();
}
