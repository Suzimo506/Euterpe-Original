using Assets.Scripts.UI.Redot.RoleSelectRedot;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000145")]
public class ElfinItem : FancyGridViewCell<ElfinItemData, ElfinItemGroupContext>
{
	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Image m_ImgUse;

	[Token(Token = "0x40007E6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image m_ImgElfin;

	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007E7")]
	private Image m_ImgLove;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40007E8")]
	[SerializeField]
	private Image m_ImgRandom;

	[Token(Token = "0x40007E9")]
	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	private Button m_Button;

	[SerializeField]
	[Token(Token = "0x40007EA")]
	[FieldOffset(Offset = "0x50")]
	private Color m_BgSelectedColor;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40007EB")]
	private Color m_BgUnSelectedColor;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40007EC")]
	[SerializeField]
	private GameObject m_LockObj;

	[SerializeField]
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40007ED")]
	private RolePreviewRedot m_Redot;

	[SerializeField]
	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x80")]
	private Text m_TextElfinName;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40007EF")]
	private RectTransform m_RectTransform;

	[Token(Token = "0x40007F0")]
	[FieldOffset(Offset = "0x90")]
	private ElfinItemData m_ItemData;

	[Token(Token = "0x170000B4")]
	public bool isSelected
	{
		[Address(RVA = "0x448940", Offset = "0x447140", Length = "0x56")]
		[Token(Token = "0x6000924")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B5")]
	public int dataIndex
	{
		[Address(RVA = "0x448910", Offset = "0x447110", Length = "0x2B")]
		[Token(Token = "0x6000925")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x448590", Offset = "0x446D90", Length = "0x161")]
	[Token(Token = "0x6000926")]
	private void Start()
	{
	}

	[Address(RVA = "0x447A10", Offset = "0x446210", Length = "0x120")]
	[Token(Token = "0x6000927")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x447F70", Offset = "0x446770", Length = "0x83")]
	private void PlayClickSfx()
	{
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x447B40", Offset = "0x446340", Length = "0x261")]
	private void OnClick()
	{
	}

	[Address(RVA = "0x447DB0", Offset = "0x4465B0", Length = "0x1B7")]
	[Token(Token = "0x600092A")]
	private void OnSelect(int index)
	{
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0x4478E0", Offset = "0x4460E0", Length = "0x125")]
	public void InitItemRedot()
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x448000", Offset = "0x446800", Length = "0x129")]
	public void RefreshItemRedotData(bool lockNew)
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x448700", Offset = "0x446F00", Length = "0x81")]
	public override void UpdateContent(ElfinItemData itemData)
	{
	}

	[Address(RVA = "0x448130", Offset = "0x446930", Length = "0x45F")]
	[Token(Token = "0x600092E")]
	private void Refresh()
	{
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0x448790", Offset = "0x446F90", Length = "0x13E")]
	protected override void UpdatePosition(float normalizedPosition, float localPosition)
	{
	}

	[Address(RVA = "0x4488D0", Offset = "0x4470D0", Length = "0x38")]
	[Token(Token = "0x6000930")]
	public ElfinItem()
	{
		((FancyGridViewCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
