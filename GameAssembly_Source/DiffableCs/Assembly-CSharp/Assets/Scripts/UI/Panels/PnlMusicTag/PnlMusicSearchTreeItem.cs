namespace Assets.Scripts.UI.Panels.PnlMusicTag;

internal class PnlMusicSearchTreeItem : BaseTreeViewItemData
{
	private SearchType m_SearchType; //Field offset: 0x30
	private string m_Title; //Field offset: 0x38

	public SearchType searchType
	{
		 get { } //Length: 4
		 set { } //Length: 95
	}

	public string title
	{
		 get { } //Length: 5
	}

	public PnlMusicSearchTreeItem() { }

	public SearchType get_searchType() { }

	public string get_title() { }

	public void set_searchType(SearchType value) { }

	public void UpdateTitle() { }

}

