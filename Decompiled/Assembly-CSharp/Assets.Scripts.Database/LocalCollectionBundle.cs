using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007AC")]
public class LocalCollectionBundle : BaseDataObject
{
	[Token(Token = "0x4002895")]
	[FieldOffset(Offset = "0x20")]
	public string title;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002896")]
	public string name;

	[Token(Token = "0x4002897")]
	[FieldOffset(Offset = "0x30")]
	public string description;

	[Address(RVA = "0x49C7D0", Offset = "0x49AFD0", Length = "0x7")]
	[Token(Token = "0x600471E")]
	public LocalCollectionBundle()
	{
	}
}
