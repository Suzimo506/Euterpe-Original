using Assets.Scripts.PeroTools.UI;
using Assets.Scripts.UI.Panels.PnlMusicTag;
using Cpp2ILInjected;
using SuperScrollView;
using UnityEngine.UI;

[Token(Token = "0x200015A")]
public class PnlMusicTagViewItem : LoopListViewItem2
{
	[Token(Token = "0x2000A34")]
	public enum TreeType
	{
		[Token(Token = "0x400364B")]
		None,
		[Token(Token = "0x400364C")]
		Title,
		[Token(Token = "0x400364D")]
		Button,
		[Token(Token = "0x400364E")]
		Split
	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000884")]
	private TreeType m_TreeType;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000885")]
	private int m_ChildCount;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000886")]
	private int m_ChildIndex;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000887")]
	private MusicButtonAreaTitle m_Title;

	[Token(Token = "0x4000888")]
	[FieldOffset(Offset = "0x70")]
	private MusicButtonCell m_Cell;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000889")]
	private Button m_Button;

	[Token(Token = "0x400088A")]
	[FieldOffset(Offset = "0x80")]
	private InputKeyBinding m_KeyBinding;

	[Token(Token = "0x170000D1")]
	public TreeType treeType
	{
		[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
		[Token(Token = "0x60009E7")]
		get
		{
			return default(TreeType);
		}
		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x7B0960", Offset = "0x7AF160", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x170000D2")]
	public InputKeyBinding cacheKeyBinding
	{
		[Address(RVA = "0x7B08B0", Offset = "0x7AF0B0", Length = "0x9C")]
		[Token(Token = "0x60009E9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D3")]
	public int childIndex
	{
		[Address(RVA = "0x429C30", Offset = "0x428430", Length = "0x4")]
		[Token(Token = "0x60009EA")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x5D3350", Offset = "0x5D1B50", Length = "0x4")]
		[Token(Token = "0x60009EB")]
		set
		{
		}
	}

	[Token(Token = "0x170000D4")]
	public int childCount
	{
		[Address(RVA = "0x4E8C70", Offset = "0x4E7470", Length = "0x4")]
		[Token(Token = "0x60009EC")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x7B0950", Offset = "0x7AF150", Length = "0x4")]
		[Token(Token = "0x60009ED")]
		set
		{
		}
	}

	[Token(Token = "0x170000D5")]
	public MusicButtonAreaTitle cacheAreaTitle
	{
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x7B0790", Offset = "0x7AEF90", Length = "0x90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D6")]
	public MusicButtonCell cacheAreaCell
	{
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x7B0700", Offset = "0x7AEF00", Length = "0x90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D7")]
	public Button cacheButton
	{
		[Address(RVA = "0x7B0820", Offset = "0x7AF020", Length = "0x90")]
		[Token(Token = "0x60009F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60009F1")]
	[Address(RVA = "0x7B06F0", Offset = "0x7AEEF0", Length = "0x7")]
	public PnlMusicTagViewItem()
	{
	}
}
