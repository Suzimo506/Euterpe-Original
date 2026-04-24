using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Interface;

[Token(Token = "0x2000729")]
public interface ISerialize
{
	[Token(Token = "0x6004240")]
	[Address(RVA = "0x0", Length = "0x0")]
	string Serialize();

	[Token(Token = "0x6004241")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Deserialize(string str);
}
