using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x2000146")]
public class LevelConfigGridView : FancyGridView<LevelConfigItemData, LevelConfigItemGroupContext>
{
	[Token(Token = "0x2000A2D")]
	private class CellGroup : DefaultCellGroup
	{
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x5BCBD0", Offset = "0x5BB3D0", Length = "0x38")]
		public CellGroup()
		{
			((FancyGridView<TItemData, TContext>.DefaultCellGroup)(object)this)._002Ector();
		}
	}

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40007F1")]
	public LevelConfigItem templateLevelConfigItem;

	[Token(Token = "0x6000931")]
	[Address(RVA = "0x5D2B70", Offset = "0x5D1370", Length = "0x66")]
	protected override void SetupCellTemplate()
	{
	}

	[Address(RVA = "0x5D2850", Offset = "0x5D1050", Length = "0xD7")]
	[Token(Token = "0x6000932")]
	protected override void Initialize()
	{
	}

	[Address(RVA = "0x5D2980", Offset = "0x5D1180", Length = "0x97")]
	[Token(Token = "0x6000933")]
	public void JumpToIndexAndInvoke(int index)
	{
	}

	[Address(RVA = "0x447090", Offset = "0x445890", Length = "0x11")]
	[Token(Token = "0x6000934")]
	public void UpdateSelection(int index)
	{
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0x5D2A20", Offset = "0x5D1220", Length = "0x4F")]
	public void SetDefaultItemIndex()
	{
	}

	[Address(RVA = "0x5D2AD0", Offset = "0x5D12D0", Length = "0x9C")]
	[Token(Token = "0x6000936")]
	public void SetSelectItemIndex(string selectingTag, int index)
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x5D2A70", Offset = "0x5D1270", Length = "0x52")]
	public void SetPnlLevelConfig(PnlLevelConfig tempPnlLevelConfig)
	{
	}

	[Address(RVA = "0x5D2930", Offset = "0x5D1130", Length = "0x41")]
	[Token(Token = "0x6000938")]
	public void JumpToAssignIndex(int index)
	{
	}

	[Address(RVA = "0x5D2BE0", Offset = "0x5D13E0", Length = "0x77")]
	[Token(Token = "0x6000939")]
	protected override void UpdatePosition(float position, bool forceRefresh)
	{
	}

	[Address(RVA = "0x5D2C60", Offset = "0x5D1460", Length = "0x38")]
	[Token(Token = "0x600093A")]
	public LevelConfigGridView()
	{
		((FancyGridView<TItemData, TContext>)(object)this)._002Ector();
	}
}
