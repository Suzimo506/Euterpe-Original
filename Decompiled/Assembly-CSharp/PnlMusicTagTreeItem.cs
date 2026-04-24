using Cpp2ILInjected;
using SuperScrollView;

[Token(Token = "0x2000156")]
public class PnlMusicTagTreeItem : BaseTreeViewItemData
{
	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x30")]
	public int albumJsonIndex;

	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0x34")]
	public int tagIndex;

	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x38")]
	private string m_Title;

	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0x40")]
	public bool isShowTitle;

	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x41")]
	public bool isUnlock;

	[Token(Token = "0x170000CB")]
	public string title
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x60009C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x7B0590", Offset = "0x7AED90", Length = "0x15C")]
	public void UpdateTitleStr()
	{
	}

	[Address(RVA = "0x7A85C0", Offset = "0x7A6DC0", Length = "0x7")]
	[Token(Token = "0x60009CA")]
	public PnlMusicTagTreeItem()
	{
	}
}
