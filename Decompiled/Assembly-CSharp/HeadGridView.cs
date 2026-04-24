using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x200015F")]
public class HeadGridView : FancyGridView<HeadItemData, HeadIemGroupContext>
{
	[Token(Token = "0x2000A35")]
	private class CellGroup : DefaultCellGroup
	{
		[Address(RVA = "0x5BCC10", Offset = "0x5BB410", Length = "0x38")]
		[Token(Token = "0x60058DB")]
		public CellGroup()
		{
			((FancyGridView<TItemData, TContext>.DefaultCellGroup)(object)this)._002Ector();
		}
	}

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008AD")]
	public HeadItem templateHeadItem;

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x5C3D70", Offset = "0x5C2570", Length = "0x66")]
	protected override void SetupCellTemplate()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000A15")]
	public void SelectAssignCell()
	{
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0x5C3D10", Offset = "0x5C2510", Length = "0x52")]
	public void SetPnlHead(PnlHead pnlHead)
	{
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0x5C3CD0", Offset = "0x5C24D0", Length = "0x32")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0x5C3BD0", Offset = "0x5C23D0", Length = "0xD7")]
	protected override void Initialize()
	{
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0x5C3DE0", Offset = "0x5C25E0", Length = "0x7B")]
	public void UpdateSelection(int index)
	{
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x5C3CB0", Offset = "0x5C24B0", Length = "0x19")]
	public void JumpToAssignIndex(int index)
	{
	}

	[Address(RVA = "0x5C3E60", Offset = "0x5C2660", Length = "0x38")]
	[Token(Token = "0x6000A1B")]
	public HeadGridView()
	{
		((FancyGridView<TItemData, TContext>)(object)this)._002Ector();
	}
}
