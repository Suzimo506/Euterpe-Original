using Cpp2ILInjected;
using UI.Components.UguiScrollViewExtend;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground.DaveMainShow;

[Token(Token = "0x2000840")]
public class ScrDaveFishItem : BaseScrollItem<ScrDaveFishData, ScrDaveFishContext>
{
	[Token(Token = "0x4002B1E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private DaveFishTypeDefines m_ImgFishTypeDefines;

	[SerializeField]
	[Token(Token = "0x4002B1F")]
	[FieldOffset(Offset = "0x30")]
	private Image m_ImgFish;

	[SerializeField]
	[Token(Token = "0x4002B20")]
	[FieldOffset(Offset = "0x38")]
	private Text m_TxtFishCount;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4002B21")]
	private Image m_ImgFishCount;

	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002B22")]
	private Image m_ImgFishType;

	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002B23")]
	private Button m_BtnShowDetail;

	[SerializeField]
	[Token(Token = "0x4002B24")]
	[FieldOffset(Offset = "0x58")]
	private Color m_ColorFishLocked;

	[Address(RVA = "0x61AAC0", Offset = "0x6192C0", Length = "0x9D")]
	[Token(Token = "0x6004BE4")]
	public override void Init(ScrDaveFishContext context = null)
	{
	}

	[Address(RVA = "0x61AC20", Offset = "0x619420", Length = "0xDC")]
	[Token(Token = "0x6004BE5")]
	public override void Select()
	{
	}

	[Address(RVA = "0x61AB60", Offset = "0x619360", Length = "0xB2")]
	[Token(Token = "0x6004BE6")]
	private void OnSelected()
	{
	}

	[Token(Token = "0x6004BE7")]
	[Address(RVA = "0x61AD80", Offset = "0x619580", Length = "0x38")]
	public override void UnSelect()
	{
	}

	[Token(Token = "0x6004BE8")]
	[Address(RVA = "0x61ADC0", Offset = "0x6195C0", Length = "0x3D0")]
	public override void UpdateData(ScrDaveFishData data)
	{
	}

	[Token(Token = "0x6004BE9")]
	[Address(RVA = "0x61A8A0", Offset = "0x6190A0", Length = "0x21B")]
	private void AdaptFishImg(FishAlignmentType type)
	{
	}

	[Token(Token = "0x6004BEA")]
	[Address(RVA = "0x61B1A0", Offset = "0x6199A0", Length = "0x38")]
	public ScrDaveFishItem()
	{
		((BaseScrollItem<, >)(object)this)._002Ector();
	}
}
