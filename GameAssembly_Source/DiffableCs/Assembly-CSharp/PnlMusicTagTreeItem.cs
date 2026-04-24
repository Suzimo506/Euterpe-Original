//Type is in global namespace

public class PnlMusicTagTreeItem : BaseTreeViewItemData
{
	public int albumJsonIndex; //Field offset: 0x30
	public int tagIndex; //Field offset: 0x34
	private string m_Title; //Field offset: 0x38
	public bool isShowTitle; //Field offset: 0x40
	public bool isUnlock; //Field offset: 0x41

	public string title
	{
		 get { } //Length: 5
	}

	public PnlMusicTagTreeItem() { }

	public string get_title() { }

	public void UpdateTitleStr() { }

}

