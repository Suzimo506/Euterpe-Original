using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Components;
using Boo.Lang;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D5")]
public class PnlFeverSetting : MonoBehaviour
{
	[Token(Token = "0x4002E24")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private Button m_BackButton;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002E25")]
	[SerializeField]
	private Button m_BtnSelect;

	[Token(Token = "0x4002E26")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_ThemeFSV;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002E27")]
	private Text m_Text;

	[Token(Token = "0x4002E28")]
	private const int select = 0;

	[Token(Token = "0x4002E29")]
	private const int selected = 1;

	[Token(Token = "0x4002E2A")]
	private const int not_purchased = 2;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002E2B")]
	[SerializeField]
	private AudioClip m_OptionBgmClip;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002E2C")]
	private DBConfigFever m_ConfigFever;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002E2D")]
	private List<int> showFeverIndexList;

	[Token(Token = "0x4002E2E")]
	[FieldOffset(Offset = "0x50")]
	private int m_CurSelectFeverBgType;

	[Token(Token = "0x1700089B")]
	private DBConfigFever configFever
	{
		[Address(RVA = "0x82E030", Offset = "0x82C830", Length = "0x5D")]
		[Token(Token = "0x6004F97")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004F98")]
	[Address(RVA = "0x82CE40", Offset = "0x82B640", Length = "0x20")]
	public void FirstInit()
	{
	}

	[Token(Token = "0x6004F99")]
	[Address(RVA = "0x82CA10", Offset = "0x82B210", Length = "0x248")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004F9A")]
	[Address(RVA = "0x82D1E0", Offset = "0x82B9E0", Length = "0x166")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004F9B")]
	[Address(RVA = "0x82CFB0", Offset = "0x82B7B0", Length = "0xFA")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004F9C")]
	[Address(RVA = "0x82D1E0", Offset = "0x82B9E0", Length = "0x166")]
	private void RefreshUI()
	{
	}

	[Address(RVA = "0x82DD00", Offset = "0x82C500", Length = "0x1E9")]
	[Token(Token = "0x6004F9D")]
	private void SetShowFeverIndexList()
	{
	}

	[Token(Token = "0x6004F9E")]
	[Address(RVA = "0x82D980", Offset = "0x82C180", Length = "0xDA")]
	private void RebuildFancy()
	{
	}

	[Token(Token = "0x6004F9F")]
	[Address(RVA = "0x82DC30", Offset = "0x82C430", Length = "0xCA")]
	private void RefreshToggleSelected()
	{
	}

	[Token(Token = "0x6004FA0")]
	[Address(RVA = "0x82DA60", Offset = "0x82C260", Length = "0x1CC")]
	private void RefreshFeverPrefab(int showIndex, int scrollViewIndex)
	{
	}

	[Address(RVA = "0x82CDA0", Offset = "0x82B5A0", Length = "0x9E")]
	[Token(Token = "0x6004FA1")]
	private int FindScrollViewIndex(int showIndex)
	{
		return default(int);
	}

	[Address(RVA = "0x82CC60", Offset = "0x82B460", Length = "0x133")]
	[Token(Token = "0x6004FA2")]
	private bool CheckBuy(int theme)
	{
		return default(bool);
	}

	[Address(RVA = "0x82DEF0", Offset = "0x82C6F0", Length = "0xC7")]
	[Token(Token = "0x6004FA3")]
	private void ToggleSelected(bool? enable, int tipIndex)
	{
	}

	[Address(RVA = "0x82CF40", Offset = "0x82B740", Length = "0x6A")]
	[Token(Token = "0x6004FA4")]
	private void OnBackClicked()
	{
	}

	[Address(RVA = "0x82D0B0", Offset = "0x82B8B0", Length = "0x124")]
	[Token(Token = "0x6004FA5")]
	private void OnDlcOut()
	{
	}

	[Address(RVA = "0x82D3C0", Offset = "0x82BBC0", Length = "0x408")]
	[Token(Token = "0x6004FA6")]
	private void OnSelectClicked()
	{
	}

	[Address(RVA = "0x82D350", Offset = "0x82BB50", Length = "0x6D")]
	[Token(Token = "0x6004FA7")]
	private void OnItemIndexChange(int scrollViewIndex)
	{
	}

	[Address(RVA = "0x82CE70", Offset = "0x82B670", Length = "0xC1")]
	[Token(Token = "0x6004FA8")]
	private void OnFsvFinalItemIndexChange(int index)
	{
	}

	[Address(RVA = "0x82CE70", Offset = "0x82B670", Length = "0xC1")]
	[Token(Token = "0x6004FA9")]
	private void ItemTimeoutCheck(int index)
	{
	}

	[Token(Token = "0x6004FAA")]
	[Address(RVA = "0x82D8C0", Offset = "0x82C0C0", Length = "0xBE")]
	private void PopupBuyMessageBox(int themeIndex)
	{
	}

	[Token(Token = "0x6004FAB")]
	[Address(RVA = "0x82D7D0", Offset = "0x82BFD0", Length = "0xEC")]
	private void PopupBuyMessageBoxInPC(DBConfigAlbums.AlbumsInfo albumName)
	{
	}

	[Token(Token = "0x6004FAC")]
	[Address(RVA = "0x82DFC0", Offset = "0x82C7C0", Length = "0x69")]
	public PnlFeverSetting()
	{
	}
}
