using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.Structs;
using Assets.Scripts.UI.Specials;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E1")]
public class PnlTroves : SerializedMonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002EFC")]
	private TroveGridView m_TroveGridView;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002EFD")]
	[SerializeField]
	private Animator m_Animator;

	[Token(Token = "0x4002EFE")]
	[FieldOffset(Offset = "0x68")]
	public AudioClip pnlTroveMusic;

	[Token(Token = "0x4002EFF")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip clickSfx;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002F00")]
	private TroveViewMode m_TroveViewMode;

	[SerializeField]
	[Token(Token = "0x4002F01")]
	[FieldOffset(Offset = "0x80")]
	private Toggle m_ToggleViewMode;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002F02")]
	private bool hasNew;

	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4002F03")]
	private bool m_IgnoreEvent;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002F04")]
	public Toggle tglUsed;

	[Token(Token = "0x4002F05")]
	[FieldOffset(Offset = "0x98")]
	public Button btnCheck_Pc;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4002F06")]
	public Button btnCheck_Mobile;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4002F07")]
	private Button m_BtnCheck;

	[Token(Token = "0x4002F08")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Button m_BtnPurchase;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002F09")]
	[SerializeField]
	private Button m_BtnConfirm;

	[Token(Token = "0x4002F0A")]
	[FieldOffset(Offset = "0xC0")]
	private List<int> m_UseLoadingIndexItem;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002F0B")]
	private List<int> m_UseWelcomeIndexItem;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002F0C")]
	private List<IData> m_Items;

	[Token(Token = "0x4002F0D")]
	[FieldOffset(Offset = "0xD8")]
	private List<int> m_UnlockedItemMappings;

	[Token(Token = "0x4002F0E")]
	[FieldOffset(Offset = "0xE0")]
	private List<int> m_LockedCharacterItems;

	[Token(Token = "0x4002F0F")]
	[FieldOffset(Offset = "0xE8")]
	private List<int> m_LockedElfinItems;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002F10")]
	private List<int> m_LockedWelcomeItems;

	[Token(Token = "0x4002F11")]
	[FieldOffset(Offset = "0xF8")]
	private List<int> m_LockedLoadingItems;

	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x100")]
	private Dictionary<string, Sprite> m_UsedTroveImg;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4002F13")]
	private Dictionary<string, int> m_UnlockedItemTypeSortMap;

	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x110")]
	private string m_SelectItemType;

	[Token(Token = "0x4002F15")]
	[FieldOffset(Offset = "0x118")]
	private int m_SelectIndex;

	[Token(Token = "0x4002F16")]
	[FieldOffset(Offset = "0x120")]
	private IData m_SelectItem;

	[Token(Token = "0x4002F17")]
	[FieldOffset(Offset = "0x128")]
	private CheckRoleItemParams m_SelectCheckRoleItemParams;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4002F18")]
	private bool m_IsSelectOffJAP;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4002F19")]
	private string m_ItemLocalName;

	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x58F40", Offset = "0x58340")]
	[Token(Token = "0x4002F1A")]
	private GameObject m_ArtistArea;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4002F1B")]
	[SerializeField]
	private GameObject m_ButtonTips;

	[Token(Token = "0x4002F1C")]
	[SerializeField]
	[FieldOffset(Offset = "0x170")]
	private Text m_Description;

	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4002F1D")]
	[SerializeField]
	private Button m_ArtistBtnBind;

	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4002F1E")]
	[SerializeField]
	private Button m_Artist1Btn;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4002F1F")]
	[SerializeField]
	private TextMeshProUGUI m_Artist1Text;

	[SerializeField]
	[Token(Token = "0x4002F20")]
	[FieldOffset(Offset = "0x190")]
	private GameObject m_Artist1Link;

	[SerializeField]
	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x198")]
	private GameObject m_AndGameObject;

	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private Button m_Artist2Btn;

	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4002F23")]
	[SerializeField]
	private TextMeshProUGUI m_Artist2Text;

	[SerializeField]
	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0x1B0")]
	private GameObject m_Artist2Link;

	[SerializeField]
	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0x1B8")]
	private GameObject m_AndGameObject2;

	[Token(Token = "0x4002F26")]
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private Button m_Artist3Btn;

	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x4002F27")]
	private TextMeshProUGUI m_Artist3Text;

	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4002F28")]
	[SerializeField]
	private GameObject m_Artist3Link;

	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x5C560", Offset = "0x5B960")]
	[Token(Token = "0x4002F29")]
	private ToggleGroup m_ParentGroup;

	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4002F2A")]
	private List<TroveItemData> m_TroveItemDatas;

	[Token(Token = "0x4002F2B")]
	[FieldOffset(Offset = "0x1E8")]
	private string m_Artist1Home;

	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4002F2C")]
	private string m_Artist2Home;

	[Token(Token = "0x4002F2D")]
	[FieldOffset(Offset = "0x1F8")]
	private string m_Artist3Home;

	[Token(Token = "0x4002F2E")]
	[FieldOffset(Offset = "0x200")]
	private bool m_LanguageDirty;

	[Token(Token = "0x4002F2F")]
	[FieldOffset(Offset = "0x201")]
	private bool m_TroveDirty;

	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4002F30")]
	private int troveCount;

	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4002F31")]
	private bool m_IsRefreshItemInit;

	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4002F32")]
	private (int, string) m_NextIll;

	[Token(Token = "0x4002F33")]
	[FieldOffset(Offset = "0x220")]
	private List<(int, string)> m_UnlockedIlls;

	[Token(Token = "0x1700089F")]
	public TroveViewMode troveViewMode
	{
		[Token(Token = "0x6005055")]
		[Address(RVA = "0x486430", Offset = "0x484C30", Length = "0x4")]
		get
		{
			return default(TroveViewMode);
		}
	}

	[Token(Token = "0x6005056")]
	[Address(RVA = "0x4C7DF0", Offset = "0x4C65F0", Length = "0x831")]
	public void Init()
	{
	}

	[Token(Token = "0x6005057")]
	[Address(RVA = "0x4C9680", Offset = "0x4C7E80", Length = "0x340")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005058")]
	[Address(RVA = "0x4C9590", Offset = "0x4C7D90", Length = "0x55")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4C9090", Offset = "0x4C7890", Length = "0x4FA")]
	[Token(Token = "0x6005059")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600505A")]
	[Address(RVA = "0x4CB350", Offset = "0x4C9B50", Length = "0x5DC")]
	private void RefreshItems()
	{
	}

	[Token(Token = "0x600505B")]
	[Address(RVA = "0x4CB1F0", Offset = "0x4C99F0", Length = "0x156")]
	private void RefreshIndexs()
	{
	}

	[Token(Token = "0x600505C")]
	[Address(RVA = "0x4CBA70", Offset = "0x4CA270", Length = "0x872")]
	private void RefreshTroveCount()
	{
	}

	[Address(RVA = "0x4C6A40", Offset = "0x4C5240", Length = "0x146")]
	[Token(Token = "0x600505D")]
	private void AdjustTroveItemObjCount()
	{
	}

	[Address(RVA = "0x4C6990", Offset = "0x4C5190", Length = "0xA4")]
	[Token(Token = "0x600505E")]
	private void AddTroveItemToTroveCount()
	{
	}

	[Address(RVA = "0x4CC2F0", Offset = "0x4CAAF0", Length = "0x88")]
	[Token(Token = "0x600505F")]
	private void RemoveTroveItemToTroveCount()
	{
	}

	[Address(RVA = "0x4CAC20", Offset = "0x4C9420", Length = "0x1A9")]
	[Token(Token = "0x6005060")]
	private void OnPurchaseRefresh()
	{
	}

	[Address(RVA = "0x4C95F0", Offset = "0x4C7DF0", Length = "0x85")]
	[Token(Token = "0x6005061")]
	private void OnDlcOut()
	{
	}

	[Address(RVA = "0x4CC460", Offset = "0x4CAC60", Length = "0x163")]
	[Token(Token = "0x6005062")]
	private void SelectPurchasedItem(int index, string type)
	{
	}

	[Token(Token = "0x6005063")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void SetScrollRectEnable(bool enable)
	{
	}

	[Address(RVA = "0x4C7AF0", Offset = "0x4C62F0", Length = "0xEB")]
	[Token(Token = "0x6005064")]
	public Sprite GetOrAddTroveImg(string imgName)
	{
		return null;
	}

	[Address(RVA = "0x4C7970", Offset = "0x4C6170", Length = "0x179")]
	[Token(Token = "0x6005065")]
	public (int, string) GetNextIll()
	{
		return default((int, string));
	}

	[Address(RVA = "0x4C7BE0", Offset = "0x4C63E0", Length = "0x18A")]
	[Token(Token = "0x6005066")]
	public (int, string) GetPreviousIll()
	{
		return default((int, string));
	}

	[Address(RVA = "0x4C8630", Offset = "0x4C6E30", Length = "0x149")]
	[Token(Token = "0x6005067")]
	public bool IsSelectItemIndexIsUsed(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x4CC750", Offset = "0x4CAF50", Length = "0x8")]
	[Token(Token = "0x6005068")]
	private void SetTroveDirty()
	{
	}

	[Address(RVA = "0x4C7D70", Offset = "0x4C6570", Length = "0x79")]
	[Token(Token = "0x6005069")]
	public int GetUnlockedItemIndex(int SiblingIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600506A")]
	[Address(RVA = "0x4C73B0", Offset = "0x4C5BB0", Length = "0x1E7")]
	public int GetLockedItemIndexAndType(int SiblingIndex, out string type)
	{
		type = null;
		return default(int);
	}

	[Address(RVA = "0x4C9010", Offset = "0x4C7810", Length = "0x74")]
	[Token(Token = "0x600506B")]
	private void OnConfirmClicked()
	{
	}

	[Address(RVA = "0x4C9000", Offset = "0x4C7800", Length = "0x7")]
	[Token(Token = "0x600506C")]
	private void OnCheckClicked()
	{
	}

	[Address(RVA = "0x4C6D20", Offset = "0x4C5520", Length = "0x194")]
	[Token(Token = "0x600506D")]
	public void ClickBtnCheck()
	{
	}

	[Address(RVA = "0x4C8DF0", Offset = "0x4C75F0", Length = "0x20D")]
	[Token(Token = "0x600506E")]
	private void OnArtistBindClicked()
	{
	}

	[Address(RVA = "0x4CB110", Offset = "0x4C9910", Length = "0xD1")]
	[Token(Token = "0x600506F")]
	private void OnToggleViewModeChanged(bool isOn)
	{
	}

	[Address(RVA = "0x4CAE20", Offset = "0x4C9620", Length = "0x2EA")]
	[Token(Token = "0x6005070")]
	private void OnTglValueChanged(bool value)
	{
	}

	[Token(Token = "0x6005071")]
	[Address(RVA = "0x4C99D0", Offset = "0x4C81D0", Length = "0x16F")]
	private void OnItemChangedFromTgl(int index, string itemType, bool isUnlock)
	{
	}

	[Address(RVA = "0x4CA8E0", Offset = "0x4C90E0", Length = "0x8")]
	[Token(Token = "0x6005072")]
	private void OnLanguageChanged(int index)
	{
	}

	[Address(RVA = "0x4CA620", Offset = "0x4C8E20", Length = "0x97")]
	[Token(Token = "0x6005073")]
	private void OnItemSelectedFromCheck(string itemType, bool isUnlock)
	{
	}

	[Address(RVA = "0x4C9BE0", Offset = "0x4C83E0", Length = "0x62E")]
	[Token(Token = "0x6005074")]
	private void OnItemSelectSetArtist()
	{
	}

	[Address(RVA = "0x4C9B40", Offset = "0x4C8340", Length = "0x9C")]
	[Token(Token = "0x6005075")]
	private void OnItemDoubleClicked(int index)
	{
	}

	[Address(RVA = "0x4CC660", Offset = "0x4CAE60", Length = "0xED")]
	[Token(Token = "0x6005076")]
	private IData SetItemDatas(int index)
	{
		return null;
	}

	[Token(Token = "0x6005077")]
	[Address(RVA = "0x4CA6C0", Offset = "0x4C8EC0", Length = "0x214")]
	private void OnItemSelected()
	{
	}

	[Address(RVA = "0x4CC5D0", Offset = "0x4CADD0", Length = "0x89")]
	[Token(Token = "0x6005078")]
	public void SelectUnLockItemByItemIndex(int targetItemIndex)
	{
	}

	[Token(Token = "0x6005079")]
	[Address(RVA = "0x4CC3F0", Offset = "0x4CABF0", Length = "0x6F")]
	public void SelectCurrentItem()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C660", Offset = "0x5BA60")]
	[Token(Token = "0x600507A")]
	[Address(RVA = "0x4CC380", Offset = "0x4CAB80", Length = "0x65")]
	private IEnumerator SelectCurrentItemCoroutine()
	{
		return null;
	}

	[Address(RVA = "0x4CA330", Offset = "0x4C8B30", Length = "0x270")]
	[Token(Token = "0x600507B")]
	private void OnItemSelectedForLockedItem()
	{
	}

	[Token(Token = "0x600507C")]
	[Address(RVA = "0x4CA5B0", Offset = "0x4C8DB0", Length = "0x6A")]
	private void OnItemSelectedForUnlockedItem()
	{
	}

	[Token(Token = "0x600507D")]
	[Address(RVA = "0x4CA210", Offset = "0x4C8A10", Length = "0x117")]
	private void OnItemSelectedCheckItemIsTimeout(string itemType, int itemIndex)
	{
	}

	[Token(Token = "0x600507E")]
	[Address(RVA = "0x4C6C70", Offset = "0x4C5470", Length = "0xAE")]
	private bool CheckItemIAPTimeout(string itemType, int itemIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x4C6B90", Offset = "0x4C5390", Length = "0xDD")]
	[Token(Token = "0x600507F")]
	private bool CheckFreeItemTimeout(string itemType, int itemIndex)
	{
		return default(bool);
	}

	[Address(RVA = "0x4C6F60", Offset = "0x4C5760", Length = "0x440")]
	[Token(Token = "0x6005080")]
	private void GetItemInfo(out string itemName, out string itemLocalName, out bool free, out bool egg)
	{
		itemName = null;
		itemLocalName = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref free) = null;
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref egg) = null;
	}

	[Address(RVA = "0x4CCA50", Offset = "0x4CB250", Length = "0xCC")]
	[Token(Token = "0x6005081")]
	private void ShowFreeUnlockDesForLockItem(string itemLocalName)
	{
	}

	[Token(Token = "0x6005082")]
	[Address(RVA = "0x4CC9C0", Offset = "0x4CB1C0", Length = "0x80")]
	private void ShowEggUnlockDesForLockItem(string itemName)
	{
	}

	[Token(Token = "0x6005083")]
	[Address(RVA = "0x4CCC30", Offset = "0x4CB430", Length = "0x36A")]
	private void ShowPurchaseUnlockDesForLockItem(string itemLocalName)
	{
	}

	[Token(Token = "0x6005084")]
	[Address(RVA = "0x4CCB20", Offset = "0x4CB320", Length = "0x104")]
	private void ShowPackagePurchaseUnlockDes(ref List<string> buffer, ref string localizationName)
	{
	}

	[Token(Token = "0x6005085")]
	[Address(RVA = "0x4C6EC0", Offset = "0x4C56C0", Length = "0x9C")]
	private string GetCurrentItemAlbumName()
	{
		return null;
	}

	[Token(Token = "0x6005086")]
	[Address(RVA = "0x4CA8F0", Offset = "0x4C90F0", Length = "0x327")]
	private void OnPurchaseClicked()
	{
	}

	[Token(Token = "0x6005087")]
	[Address(RVA = "0x4CCFA0", Offset = "0x4CB7A0", Length = "0xB8")]
	private bool TimeLimitedProductTipsShow()
	{
		return default(bool);
	}

	[Token(Token = "0x6005088")]
	[Address(RVA = "0x4C8830", Offset = "0x4C7030", Length = "0xF4")]
	private void NormalProductTipsShow()
	{
	}

	[Address(RVA = "0x4C8930", Offset = "0x4C7130", Length = "0x126")]
	[Token(Token = "0x6005089")]
	private void OffJAPProductTipsShow()
	{
	}

	[Address(RVA = "0x4C8780", Offset = "0x4C6F80", Length = "0xA2")]
	[Token(Token = "0x600508A")]
	private void JumpToShop()
	{
	}

	[Address(RVA = "0x4C8A60", Offset = "0x4C7260", Length = "0x120")]
	[Token(Token = "0x600508B")]
	private void OnArtist1Clicked()
	{
	}

	[Address(RVA = "0x4C8B90", Offset = "0x4C7390", Length = "0x120")]
	[Token(Token = "0x600508C")]
	private void OnArtist2Clicked()
	{
	}

	[Address(RVA = "0x4C8CC0", Offset = "0x4C74C0", Length = "0x120")]
	[Token(Token = "0x600508D")]
	private void OnArtist3Clicked()
	{
	}

	[Address(RVA = "0x4CADD0", Offset = "0x4C95D0", Length = "0x43")]
	[Token(Token = "0x600508E")]
	private void OnTerminalRestore()
	{
	}

	[Address(RVA = "0x4CB930", Offset = "0x4CA130", Length = "0x13E")]
	[Token(Token = "0x600508F")]
	public void RefreshNavigation()
	{
	}

	[Address(RVA = "0x4CC760", Offset = "0x4CAF60", Length = "0x259")]
	[Token(Token = "0x6005090")]
	private void SetupNavigation(List<RectTransform> listemp)
	{
	}

	[Address(RVA = "0x4C75A0", Offset = "0x4C5DA0", Length = "0x3C3")]
	[Token(Token = "0x6005091")]
	private Selectable GetNearestInDirection(RectTransform currentRect, List<RectTransform> list, int direction)
	{
		return null;
	}

	[Address(RVA = "0x4CD080", Offset = "0x4CB880", Length = "0x181")]
	[Token(Token = "0x6005092")]
	public PnlTroves()
	{
	}
}
