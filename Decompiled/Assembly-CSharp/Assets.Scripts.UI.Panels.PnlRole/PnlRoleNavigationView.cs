using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000967")]
public class PnlRoleNavigationView : PnlRoleSelectedItem, ILevelConfigUI
{
	[Token(Token = "0x2000DDA")]
	public class NavigationInfo
	{
		[Token(Token = "0x40040F4")]
		[FieldOffset(Offset = "0x10")]
		public int characterIndex;

		[Token(Token = "0x40040F5")]
		[FieldOffset(Offset = "0x14")]
		public int characterOrder;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40040F6")]
		public int pnlRoleIndex;

		[Token(Token = "0x40040F7")]
		[FieldOffset(Offset = "0x20")]
		public string characterName;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40040F8")]
		public string characterType;

		[Token(Token = "0x40040F9")]
		[FieldOffset(Offset = "0x30")]
		public string characterSkill;

		[Token(Token = "0x40040FA")]
		[FieldOffset(Offset = "0x38")]
		public Sprite characterSprite;

		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40040FB")]
		public bool isSpecial;

		[Token(Token = "0x40040FC")]
		[FieldOffset(Offset = "0x41")]
		public bool free;

		[FieldOffset(Offset = "0x42")]
		[Token(Token = "0x40040FD")]
		public bool isUnlocked;

		[FieldOffset(Offset = "0x43")]
		[Token(Token = "0x40040FE")]
		public bool isTryOut;

		[Token(Token = "0x40040FF")]
		[FieldOffset(Offset = "0x44")]
		public bool isUnlockedByVip;

		[Token(Token = "0x17000B2D")]
		public bool isRandom
		{
			[Token(Token = "0x60065F0")]
			[Address(RVA = "0x638760", Offset = "0x636F60", Length = "0x7E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60065F1")]
			[Address(RVA = "0x6387E0", Offset = "0x636FE0", Length = "0x7A")]
			set
			{
			}
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x60065F2")]
		public NavigationInfo()
		{
		}
	}

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4003372")]
	[SerializeField]
	private PnlRole m_PnlRole;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4003373")]
	[SerializeField]
	private GameObject m_NavigationItemPrefab;

	[Token(Token = "0x4003374")]
	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	private PeroScrollRect m_ScrollRect;

	[SerializeField]
	[Token(Token = "0x4003375")]
	[FieldOffset(Offset = "0x98")]
	private Transform m_Content;

	[SerializeField]
	[Token(Token = "0x4003376")]
	[FieldOffset(Offset = "0xA0")]
	private Button m_BtnBack;

	[SerializeField]
	[Token(Token = "0x4003377")]
	[FieldOffset(Offset = "0xA8")]
	private RectTransform m_ImgSelectTransform;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4003378")]
	[SerializeField]
	private RectTransform m_DescriptionTransform;

	[Token(Token = "0x4003379")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private PnlRoleBtnLove m_PnlRoleBtnLove;

	[Token(Token = "0x400337A")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Button m_BtnLove;

	[SerializeField]
	[Token(Token = "0x400337B")]
	[FieldOffset(Offset = "0xC8")]
	private Button m_BtnChangeRandom;

	[SerializeField]
	[Token(Token = "0x400337C")]
	[FieldOffset(Offset = "0xD0")]
	private PnlRoleScrollTxtFitter m_ScrollTxtFitter;

	[SerializeField]
	[Token(Token = "0x400337D")]
	[FieldOffset(Offset = "0xD8")]
	private BtnApply m_BtnApply;

	[Token(Token = "0x400337E")]
	[FieldOffset(Offset = "0xE0")]
	private Vector2 m_MainDescriptionSizeDelta;

	[Token(Token = "0x400337F")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private Vector2 m_NavigationDescriptionSizeDelta;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003380")]
	private string m_AllTypeStr;

	[Token(Token = "0x4003381")]
	[FieldOffset(Offset = "0xF8")]
	private string m_RinTypeStr;

	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4003382")]
	private string m_BuroTypeStr;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4003383")]
	private string m_MarijaTypeStr;

	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4003384")]
	private string m_SpecialTypeStr;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4003385")]
	private Dictionary<string, List<NavigationInfo>> m_CharacterTypeToInfoListMapping;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4003386")]
	private List<PnlRoleNavigationItem> m_NavigationItems;

	[Token(Token = "0x4003387")]
	[FieldOffset(Offset = "0x128")]
	private int m_ActiveItemCount;

	[Token(Token = "0x4003388")]
	private static string m_CurCharacterType;

	[Token(Token = "0x4003389")]
	[FieldOffset(Offset = "0x12C")]
	private (BtnApply.ButtonState, int) m_TempNavData;

	[Token(Token = "0x400338A")]
	private static Dictionary<LevelConfigUIState, int> m_DicCurCellIndexs;

	[Token(Token = "0x400338B")]
	[FieldOffset(Offset = "0x134")]
	private float m_AxisCoolDownTime;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400338C")]
	private float m_AxisCoolDownTimer;

	[Token(Token = "0x400338D")]
	[FieldOffset(Offset = "0x140")]
	private string m_Language;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400338E")]
	private bool isOpened;

	[Token(Token = "0x400338F")]
	private static LevelConfigUIState m_CurrentUIState;

	[Token(Token = "0x170008F9")]
	public Dictionary<string, List<NavigationInfo>> CharacterTypeToInfoListMapping
	{
		[Token(Token = "0x60055A7")]
		[Address(RVA = "0x427D10", Offset = "0x426510", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008FA")]
	private static int m_CurIndex
	{
		[Address(RVA = "0x63FBF0", Offset = "0x63E3F0", Length = "0x108")]
		[Token(Token = "0x60055A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60055A9")]
		[Address(RVA = "0x63FD00", Offset = "0x63E500", Length = "0x77")]
		set
		{
		}
	}

	[Token(Token = "0x170008FB")]
	public LevelConfigUIState currentUIState
	{
		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x63FB90", Offset = "0x63E390", Length = "0x56")]
		get
		{
			return default(LevelConfigUIState);
		}
	}

	[Token(Token = "0x60055AB")]
	[Address(RVA = "0x63C1E0", Offset = "0x63A9E0", Length = "0x5B")]
	public void ChangeLevelConfigUIState(LevelConfigUIState newState)
	{
	}

	[Token(Token = "0x60055AC")]
	[Address(RVA = "0x63BD30", Offset = "0x63A530", Length = "0x4AB")]
	private void Awake()
	{
	}

	[Token(Token = "0x60055AD")]
	[Address(RVA = "0x63D600", Offset = "0x63BE00", Length = "0x17E")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x63D4F0", Offset = "0x63BCF0", Length = "0x10F")]
	[Token(Token = "0x60055AE")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60055AF")]
	[Address(RVA = "0x63D3C0", Offset = "0x63BBC0", Length = "0x120")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60055B0")]
	[Address(RVA = "0x63C4E0", Offset = "0x63ACE0", Length = "0x9A3")]
	private void InitNavigationInfoMapping()
	{
	}

	[Token(Token = "0x60055B1")]
	[Address(RVA = "0x63C3D0", Offset = "0x63ABD0", Length = "0x100")]
	private void InitNavigationInfoMappingForType()
	{
	}

	[Address(RVA = "0x63C390", Offset = "0x63AB90", Length = "0x3E")]
	[Token(Token = "0x60055B2")]
	private int CompareNavigationInfo(NavigationInfo info1, NavigationInfo info2)
	{
		return default(int);
	}

	[Address(RVA = "0x63CE90", Offset = "0x63B690", Length = "0x321")]
	[Token(Token = "0x60055B3")]
	public void InitShowView()
	{
	}

	[Address(RVA = "0x63E940", Offset = "0x63D140", Length = "0x638")]
	[Token(Token = "0x60055B4")]
	public void ShowViewByCharacterType(string characterType)
	{
	}

	[Address(RVA = "0x63DEC0", Offset = "0x63C6C0", Length = "0x2DF")]
	[Token(Token = "0x60055B5")]
	public void RefreshRedotStatesByCharacterType(string characterType, out bool hasUnfocusedCharacter)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref hasUnfocusedCharacter) = null;
	}

	[Token(Token = "0x60055B6")]
	[Address(RVA = "0x63BBB0", Offset = "0x63A3B0", Length = "0x178")]
	private void AdjustActiveItems(string characterType)
	{
	}

	[Address(RVA = "0x63DA50", Offset = "0x63C250", Length = "0x2DB")]
	[Token(Token = "0x60055B7")]
	private void RefreshLanguage()
	{
	}

	[Address(RVA = "0x63E2F0", Offset = "0x63CAF0", Length = "0x2B9")]
	[Token(Token = "0x60055B8")]
	private void RefreshRoleValid()
	{
	}

	[Address(RVA = "0x63E1A0", Offset = "0x63C9A0", Length = "0x148")]
	[Token(Token = "0x60055B9")]
	private void RefreshRoleUnlock()
	{
	}

	[Address(RVA = "0x63EF80", Offset = "0x63D780", Length = "0x1DD")]
	[Token(Token = "0x60055BA")]
	private void SortCurList()
	{
	}

	[Token(Token = "0x60055BB")]
	[Address(RVA = "0x63DD30", Offset = "0x63C530", Length = "0x185")]
	private void RefreshLove()
	{
	}

	[Address(RVA = "0x63C240", Offset = "0x63AA40", Length = "0x14C")]
	[Token(Token = "0x60055BC")]
	private void ChangeLove()
	{
	}

	[Address(RVA = "0x63D8D0", Offset = "0x63C0D0", Length = "0x17D")]
	[Token(Token = "0x60055BD")]
	public void RefreshCurList()
	{
	}

	[Address(RVA = "0x63F2E0", Offset = "0x63DAE0", Length = "0xD4")]
	[Token(Token = "0x60055BE")]
	private void TurnVertical(int value)
	{
	}

	[Address(RVA = "0x63F1F0", Offset = "0x63D9F0", Length = "0xE7")]
	[Token(Token = "0x60055BF")]
	private void TurnHorizontal(int value)
	{
	}

	[Token(Token = "0x60055C0")]
	[Address(RVA = "0x63F9D0", Offset = "0x63E1D0", Length = "0x88")]
	private void Update()
	{
	}

	[Address(RVA = "0x63F160", Offset = "0x63D960", Length = "0x89")]
	[Token(Token = "0x60055C1")]
	private void TurnByAxis(float value, Action<int> action)
	{
	}

	[Address(RVA = "0x63E5B0", Offset = "0x63CDB0", Length = "0x38B")]
	[Token(Token = "0x60055C2")]
	private void SelectItem(int newIndex, string newCharacterType)
	{
	}

	[Address(RVA = "0x63D780", Offset = "0x63BF80", Length = "0x14B")]
	[Token(Token = "0x60055C3")]
	private (BtnApply.ButtonState, int) RefreshButton()
	{
		return default((BtnApply.ButtonState, int));
	}

	[Token(Token = "0x60055C4")]
	[Address(RVA = "0x63D1C0", Offset = "0x63B9C0", Length = "0xFF")]
	private void JumpToSelectedCharacterWithApply()
	{
	}

	[Token(Token = "0x60055C5")]
	[Address(RVA = "0x63D2C0", Offset = "0x63BAC0", Length = "0xFF")]
	private void JumpToSelectedCharacterWithoutApply()
	{
	}

	[Address(RVA = "0x63FAE0", Offset = "0x63E2E0", Length = "0xAB")]
	[Token(Token = "0x60055C6")]
	public PnlRoleNavigationView()
	{
	}
}
