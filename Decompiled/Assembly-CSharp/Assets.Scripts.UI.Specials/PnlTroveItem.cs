using System;
using System.Collections;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;
using SuperScrollView;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000865")]
public class PnlTroveItem : FancyGridViewCell<TroveItemData, TroveItemGroupContext>
{
	[Serializable]
	[Token(Token = "0x2000D36")]
	private class TroveItemScheme
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003F05")]
		public GameObject imgNew;

		[Token(Token = "0x4003F06")]
		[FieldOffset(Offset = "0x18")]
		public Text txtValue;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003F07")]
		public GameObject imgUse;

		[Token(Token = "0x4003F08")]
		[FieldOffset(Offset = "0x28")]
		public Image chipImg;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003F09")]
		public Image fullImg;

		[Token(Token = "0x4003F0A")]
		[FieldOffset(Offset = "0x38")]
		public Toggle itemTgl;

		[Token(Token = "0x4003F0B")]
		[FieldOffset(Offset = "0x40")]
		public ClickEventListener clickEventListener;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4003F0C")]
		public Text txtItemTypeName;

		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0x50")]
		public Image imgItemType;

		[Token(Token = "0x4003F0E")]
		[FieldOffset(Offset = "0x58")]
		public Vector2 cellSize;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x60063C0")]
		public TroveItemScheme()
		{
		}
	}

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002BD5")]
	private TroveItemScheme m_ChipTroveViewScheme;

	[SerializeField]
	[Token(Token = "0x4002BD6")]
	[FieldOffset(Offset = "0x30")]
	private TroveItemScheme m_FullTroveViewScheme;

	[Token(Token = "0x4002BD7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002BD8")]
	private GameObject m_ImgNew;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002BD9")]
	private Text m_TxtValue;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002BDA")]
	private GameObject m_ImgUse;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002BDB")]
	private Image m_ChipImg;

	[Token(Token = "0x4002BDC")]
	[FieldOffset(Offset = "0x60")]
	private Image m_FullImg;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002BDD")]
	private Toggle m_ItemTgl;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002BDE")]
	private PnlTroves m_Parent;

	[Token(Token = "0x4002BDF")]
	[FieldOffset(Offset = "0x78")]
	private Text m_TxtItemTypeName;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002BE0")]
	private Image m_ImgItemType;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002BE1")]
	private bool wasOn;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002BE2")]
	private WaitForEndOfFrame m_WaitForEndOfFrame;

	[Token(Token = "0x4002BE3")]
	private const string chracter_type_name = "CHARACTER";

	[Token(Token = "0x4002BE4")]
	private const string elfin_type_name = "ELFIN";

	[Token(Token = "0x4002BE5")]
	private const string loading_type_name = "LOADING";

	[Token(Token = "0x4002BE6")]
	private const string welcome_type_name = "WELCOME";

	[Token(Token = "0x4002BE7")]
	private const string chracter_type_icon = "SprIconRole";

	[Token(Token = "0x4002BE8")]
	private const string elfin_type_icon = "SprIconElfin";

	[Token(Token = "0x4002BE9")]
	private const string loading_type_icon = "SprIconTrove";

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002BEA")]
	[SerializeField]
	private Transform m_ChipModeElementRoot;

	[Token(Token = "0x4002BEB")]
	[SerializeField]
	[FieldOffset(Offset = "0xA0")]
	private Transform m_FullModeElementRoot;

	[SerializeField]
	[Token(Token = "0x4002BEC")]
	[FieldOffset(Offset = "0xA8")]
	private Color m_UnlockedColor;

	[SerializeField]
	[Token(Token = "0x4002BED")]
	[FieldOffset(Offset = "0xB8")]
	private Color m_LockedColor;

	[SerializeField]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002BEE")]
	private TroveItemData m_ItemData;

	[Token(Token = "0x17000868")]
	public TroveItemData itemData
	{
		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x460220", Offset = "0x45EA20", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000869")]
	public bool IsEmpty
	{
		[Token(Token = "0x6004CBF")]
		[Address(RVA = "0x6189E0", Offset = "0x6171E0", Length = "0x7A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004CC0")]
	[Address(RVA = "0x6170C0", Offset = "0x6158C0", Length = "0x2E9")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6004CC1")]
	[Address(RVA = "0x6177A0", Offset = "0x615FA0", Length = "0x19F")]
	private void OnToggleValueChanged(bool isOn)
	{
	}

	[Address(RVA = "0x618350", Offset = "0x616B50", Length = "0x65")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x31F30", Offset = "0x31330")]
	[Token(Token = "0x6004CC2")]
	private IEnumerator RestoreToggleState()
	{
		return null;
	}

	[Address(RVA = "0x6176B0", Offset = "0x615EB0", Length = "0xEE")]
	[Token(Token = "0x6004CC3")]
	private void OnToggleClick(GameObject go)
	{
	}

	[Token(Token = "0x6004CC4")]
	[Address(RVA = "0x6183C0", Offset = "0x616BC0", Length = "0xB6")]
	public void SelectCurrentTgl()
	{
	}

	[Address(RVA = "0x6188F0", Offset = "0x6170F0", Length = "0x1E")]
	[Token(Token = "0x6004CC5")]
	public void SetTglUseValue(bool bIsOn)
	{
	}

	[Address(RVA = "0x618090", Offset = "0x616890", Length = "0x2BB")]
	[Token(Token = "0x6004CC6")]
	private void RefreshViewMode()
	{
	}

	[Token(Token = "0x6004CC7")]
	[Address(RVA = "0x617F10", Offset = "0x616710", Length = "0x17E")]
	public void RefreshItem()
	{
	}

	[Token(Token = "0x6004CC8")]
	[Address(RVA = "0x617AE0", Offset = "0x6162E0", Length = "0x2D1")]
	private void RefreshForUnlockedItem()
	{
	}

	[Token(Token = "0x6004CC9")]
	[Address(RVA = "0x617DC0", Offset = "0x6165C0", Length = "0x14D")]
	private void RefreshForlockedItem()
	{
	}

	[Token(Token = "0x6004CCA")]
	[Address(RVA = "0x616E60", Offset = "0x615660", Length = "0x256")]
	private bool CheckVersionNewItemForLockedItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6004CCB")]
	[Address(RVA = "0x616E00", Offset = "0x615600", Length = "0x5A")]
	public bool CheckSelected(int index, string type)
	{
		return default(bool);
	}

	[Address(RVA = "0x618480", Offset = "0x616C80", Length = "0x46F")]
	[Token(Token = "0x6004CCC")]
	private void SetImage()
	{
	}

	[Token(Token = "0x6004CCD")]
	[Address(RVA = "0x617940", Offset = "0x616140", Length = "0x199")]
	private void ReFreshFullImg(string loadFullImgName)
	{
	}

	[Token(Token = "0x6004CCE")]
	[Address(RVA = "0x6173B0", Offset = "0x615BB0", Length = "0x9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004CCF")]
	[Address(RVA = "0x617580", Offset = "0x615D80", Length = "0x127")]
	private void OnRefreshUseImg()
	{
	}

	[Token(Token = "0x6004CD0")]
	[Address(RVA = "0x617450", Offset = "0x615C50", Length = "0xC3")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x617520", Offset = "0x615D20", Length = "0x57")]
	[Token(Token = "0x6004CD1")]
	public void OnDoubleClicked(GameObject go)
	{
	}

	[Address(RVA = "0x618910", Offset = "0x617110", Length = "0x54")]
	[Token(Token = "0x6004CD2")]
	public override void UpdateContent(TroveItemData itemData)
	{
	}

	[Token(Token = "0x6004CD3")]
	[Address(RVA = "0x618970", Offset = "0x617170", Length = "0x6C")]
	public PnlTroveItem()
	{
		((FancyGridViewCell<TItemData, TContext>)(object)this)._002Ector();
	}
}
