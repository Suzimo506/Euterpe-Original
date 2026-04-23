using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Platforms;

[Token(Token = "0x20005BC")]
public interface ISync
{
	[Token(Token = "0x600397A")]
	[Address(RVA = "0x0", Length = "0x0")]
	void SaveLocal();

	[Token(Token = "0x600397B")]
	[Address(RVA = "0x0", Length = "0x0")]
	void LoadLocal();
}
