using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine.UI;

[Token(Token = "0x2000110")]
public class MusicPackageJumpItem : FancyScrollRectCell<VipItemData, MusicPackageJumpGroupContext>
{
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x28")]
	public Text txtTitle;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x30")]
	public Button btnJump;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400069F")]
	private VipItemData m_ItemData;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x40")]
	private string m_SpecialTypeStr;

	[Address(RVA = "0x8C5CD0", Offset = "0x8C44D0", Length = "0x98")]
	[Token(Token = "0x60007D4")]
	public override void Initialize()
	{
	}

	[Address(RVA = "0x8C6170", Offset = "0x8C4970", Length = "0x25")]
	[Token(Token = "0x60007D5")]
	public override void UpdateContent(VipItemData itemData)
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x8C5E30", Offset = "0x8C4630", Length = "0x2B3")]
	private void Refresh()
	{
	}

	[Address(RVA = "0x8C5D70", Offset = "0x8C4570", Length = "0xBB")]
	[Token(Token = "0x60007D7")]
	public void OnClick()
	{
	}

	[Address(RVA = "0x8C61A0", Offset = "0x8C49A0", Length = "0x13E")]
	[Token(Token = "0x60007D8")]
	protected override void UpdatePosition(float normalizedPosition, float localPosition)
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x8C62E0", Offset = "0x8C4AE0", Length = "0x4B")]
	public MusicPackageJumpItem()
	{
		((FancyScrollRectCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
