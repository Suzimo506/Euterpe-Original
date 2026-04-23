using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000162")]
public class HeadItem : FancyGridViewCell<HeadItemData, HeadIemGroupContext>
{
	[Token(Token = "0x40008B3")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private Image m_ImgBg;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008B4")]
	private Image m_ImgHead;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008B5")]
	private Image m_ImgLock;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008B6")]
	[SerializeField]
	private Button m_Button;

	[SerializeField]
	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x48")]
	private Color m_BgUnlockColor;

	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008B8")]
	private Color m_BgLockedColor;

	[SerializeField]
	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x68")]
	private Color m_BgApplyColor;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008BA")]
	[SerializeField]
	private Color m_HeadUnlockColor;

	[Token(Token = "0x40008BB")]
	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	private Color m_HeadLockedColor;

	[SerializeField]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008BC")]
	private GameObject m_ImgRedDot;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008BD")]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008BE")]
	private HeadItemData m_ItemData;

	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_IsSelected;

	[Address(RVA = "0x5C4950", Offset = "0x5C3150", Length = "0x4A")]
	[Token(Token = "0x6000A20")]
	private void Start()
	{
	}

	[Address(RVA = "0x5C3F80", Offset = "0x5C2780", Length = "0x98")]
	[Token(Token = "0x6000A21")]
	public override void Initialize()
	{
	}

	[Address(RVA = "0x5C4630", Offset = "0x5C2E30", Length = "0x83")]
	[Token(Token = "0x6000A22")]
	private void PlayClickSfx()
	{
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x5C4210", Offset = "0x5C2A10", Length = "0x411")]
	private void OnClick()
	{
	}

	[Address(RVA = "0x5C4020", Offset = "0x5C2820", Length = "0xB4")]
	[Token(Token = "0x6000A24")]
	private void JumpToShop()
	{
	}

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x5C40E0", Offset = "0x5C28E0", Length = "0x12C")]
	private void NormalProductTipsShow(string title, string des)
	{
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x5C4AB0", Offset = "0x5C32B0", Length = "0x107")]
	public override void UpdateContent(HeadItemData itemData)
	{
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x5C46C0", Offset = "0x5C2EC0", Length = "0x280")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x5C4BC0", Offset = "0x5C33C0", Length = "0x13E")]
	protected override void UpdatePosition(float normalizedPosition, float localPosition)
	{
	}

	[Address(RVA = "0x5C4D00", Offset = "0x5C3500", Length = "0x38")]
	[Token(Token = "0x6000A29")]
	public HeadItem()
	{
		((FancyGridViewCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
