using Cpp2ILInjected;

[Token(Token = "0x20000FF")]
public class CollectionBundleSelectItemData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000647")]
	public string uid;

	[Token(Token = "0x4000648")]
	[FieldOffset(Offset = "0x18")]
	public int siblingIndex;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000649")]
	public int jsonIndex;

	[Token(Token = "0x400064A")]
	[FieldOffset(Offset = "0x20")]
	public bool isCollectionBundle;

	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x24")]
	public PackageState curState;

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public CollectionBundleSelectItemData()
	{
	}
}
