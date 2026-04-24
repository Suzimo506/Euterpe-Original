//Type is in global namespace

public class PnlMusicTagViewItem : LoopListViewItem2
{
	internal enum TreeType
	{
		None = 0,
		Title = 1,
		Button = 2,
		Split = 3,
	}

	private TreeType m_TreeType; //Field offset: 0x58
	private int m_ChildCount; //Field offset: 0x5C
	private int m_ChildIndex; //Field offset: 0x60
	private MusicButtonAreaTitle m_Title; //Field offset: 0x68
	private MusicButtonCell m_Cell; //Field offset: 0x70
	private Button m_Button; //Field offset: 0x78
	private InputKeyBinding m_KeyBinding; //Field offset: 0x80

	public MusicButtonCell cacheAreaCell
	{
		 get { } //Length: 144
	}

	public MusicButtonAreaTitle cacheAreaTitle
	{
		 get { } //Length: 144
	}

	public Button cacheButton
	{
		 get { } //Length: 144
	}

	public InputKeyBinding cacheKeyBinding
	{
		 get { } //Length: 156
	}

	public int childCount
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int childIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public TreeType treeType
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public PnlMusicTagViewItem() { }

	public MusicButtonCell get_cacheAreaCell() { }

	public MusicButtonAreaTitle get_cacheAreaTitle() { }

	public Button get_cacheButton() { }

	public InputKeyBinding get_cacheKeyBinding() { }

	public int get_childCount() { }

	public int get_childIndex() { }

	public TreeType get_treeType() { }

	public void set_childCount(int value) { }

	public void set_childIndex(int value) { }

	public void set_treeType(TreeType value) { }

}

