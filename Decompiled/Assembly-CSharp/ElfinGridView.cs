using Assets.Scripts.Database;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x2000142")]
public class ElfinGridView : FancyGridView<ElfinItemData, ElfinItemGroupContext>
{
	[Token(Token = "0x2000A2C")]
	private class CellGroup : DefaultCellGroup
	{
		[Address(RVA = "0x4406C0", Offset = "0x43EEC0", Length = "0x38")]
		[Token(Token = "0x60058C4")]
		public CellGroup()
		{
			((FancyGridView<TItemData, TContext>.DefaultCellGroup)(object)this)._002Ector();
		}
	}

	[Token(Token = "0x40007D9")]
	[FieldOffset(Offset = "0x88")]
	public ElfinItem templateElfinItem;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40007DA")]
	public float ali;

	[Token(Token = "0x170000AB")]
	public ElfinInfo selectedElfinInfo
	{
		[Address(RVA = "0x447310", Offset = "0x445B10", Length = "0xAC")]
		[Token(Token = "0x600090C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000AC")]
	public int selectedIndex
	{
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x4473C0", Offset = "0x445BC0", Length = "0x3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000AD")]
	public int selectedOrderIndex
	{
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x447400", Offset = "0x445C00", Length = "0x3B")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x447440", Offset = "0x445C40", Length = "0x46")]
		set
		{
		}
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0x447200", Offset = "0x445A00", Length = "0x66")]
	protected override void SetupCellTemplate()
	{
	}

	[Token(Token = "0x6000910")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SelectAssignCell()
	{
	}

	[Token(Token = "0x6000911")]
	[Address(RVA = "0x4471A0", Offset = "0x4459A0", Length = "0x52")]
	public void SetPnlElfin(PnlElfin pnlElfin)
	{
	}

	[Address(RVA = "0x446FF0", Offset = "0x4457F0", Length = "0x98")]
	[Token(Token = "0x6000912")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000913")]
	[Address(RVA = "0x446F10", Offset = "0x445710", Length = "0xD7")]
	protected override void Initialize()
	{
	}

	[Address(RVA = "0x447270", Offset = "0x445A70", Length = "0x4B")]
	[Token(Token = "0x6000914")]
	private void UpdateSelection(int dataIndex)
	{
	}

	[Address(RVA = "0x446EA0", Offset = "0x4456A0", Length = "0x66")]
	[Token(Token = "0x6000915")]
	public void ChangeSelect(int dataIndex)
	{
	}

	[Token(Token = "0x6000916")]
	[Address(RVA = "0x446E00", Offset = "0x445600", Length = "0x90")]
	public void ChangeSelectInPCAndNS(int dataIndex, int cellIndex)
	{
	}

	[Address(RVA = "0x447090", Offset = "0x445890", Length = "0x11")]
	[Token(Token = "0x6000917")]
	public void RefreshSelf()
	{
	}

	[Address(RVA = "0x4470B0", Offset = "0x4458B0", Length = "0xEB")]
	[Token(Token = "0x6000918")]
	protected override void Refresh()
	{
	}

	[Address(RVA = "0x4472C0", Offset = "0x445AC0", Length = "0x42")]
	[Token(Token = "0x6000919")]
	public ElfinGridView()
	{
		((FancyGridView<TItemData, TContext>)(object)this)._002Ector();
	}
}
