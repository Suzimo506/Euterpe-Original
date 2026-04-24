using Cpp2ILInjected;
using SuperScrollView;

namespace Assets.Scripts.UI.Panels.PnlMusicTag;

[Token(Token = "0x20008FD")]
internal class PnlMusicSearchTreeItem : BaseTreeViewItemData
{
	[Token(Token = "0x4003024")]
	[FieldOffset(Offset = "0x30")]
	private SearchType m_SearchType;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003025")]
	private string m_Title;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4003026")]
	public int albumId;

	[Token(Token = "0x170008AD")]
	public SearchType searchType
	{
		[Token(Token = "0x600519F")]
		[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
		get
		{
			return default(SearchType);
		}
		[Token(Token = "0x60051A0")]
		[Address(RVA = "0x67F3F0", Offset = "0x67DBF0", Length = "0xA")]
		set
		{
		}
	}

	[Token(Token = "0x170008AE")]
	public string title
	{
		[Address(RVA = "0x43F3C0", Offset = "0x43DBC0", Length = "0x5")]
		[Token(Token = "0x60051A1")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x67F360", Offset = "0x67DB60", Length = "0x7C")]
	[Token(Token = "0x60051A2")]
	public void UpdateTitle()
	{
	}

	[Token(Token = "0x60051A3")]
	[Address(RVA = "0x67F3E0", Offset = "0x67DBE0", Length = "0xE")]
	public PnlMusicSearchTreeItem()
	{
	}
}
