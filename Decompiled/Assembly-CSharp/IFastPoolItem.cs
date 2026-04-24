using Cpp2ILInjected;

[Token(Token = "0x2000073")]
public interface IFastPoolItem
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000373")]
	void OnFastInstantiate();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6000374")]
	void OnFastDestroy();
}
