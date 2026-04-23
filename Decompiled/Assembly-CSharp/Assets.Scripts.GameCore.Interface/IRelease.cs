using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Interface;

[Token(Token = "0x2000728")]
public interface IRelease
{
	[Token(Token = "0x600423F")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Release(bool isEditor);
}
