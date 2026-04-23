using Cpp2ILInjected;
using SuperScrollView;

[Token(Token = "0x2000152")]
public class PnlMusicDiffTreeItem : BaseTreeViewItemData
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000839")]
	public int diffIndex;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400083A")]
	private string m_Title;

	[Token(Token = "0x170000C4")]
	public string title
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x6000988")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x7A8520", Offset = "0x7A6D20", Length = "0x95")]
	[Token(Token = "0x6000989")]
	public void UpdateTitleStr()
	{
	}

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x7A85C0", Offset = "0x7A6DC0", Length = "0x7")]
	public PnlMusicDiffTreeItem()
	{
	}
}
