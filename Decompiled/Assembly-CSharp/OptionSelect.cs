using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assets.Scripts.UI;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F0")]
public class OptionSelect : UISelectManage
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Token(Token = "0x2000A04")]
	private struct OptionIndexDefines
	{
		[Token(Token = "0x40035C0")]
		public const int how_to_play = 0;

		[Token(Token = "0x40035C1")]
		public const int switch_language = 1;

		[Token(Token = "0x40035C2")]
		public const int volume = 2;

		[Token(Token = "0x40035C3")]
		public const int display = 3;

		[Token(Token = "0x40035C4")]
		public const int input = 4;

		[Token(Token = "0x40035C5")]
		public const int offset = 5;

		[Token(Token = "0x40035C6")]
		public const int anchor = 6;

		[Token(Token = "0x40035C7")]
		public const int credit = 7;

		[Token(Token = "0x40035C8")]
		public const int rate_us = 8;

		[Token(Token = "0x40035C9")]
		public const int follow_us = 9;

		[Token(Token = "0x40035CA")]
		public const int q_a = 10;

		[Token(Token = "0x40035CB")]
		public const int feedback = 11;

		[Token(Token = "0x40035CC")]
		public const int terminal = 12;

		[Token(Token = "0x40035CD")]
		public const int bulletin = 13;

		[Token(Token = "0x40035CE")]
		public const int account = 14;

		[Token(Token = "0x40035CF")]
		public const int pero_shop = 15;

		[Token(Token = "0x40035D0")]
		public const int download_manage = 16;

		[Token(Token = "0x40035D1")]
		public const int play_setting = 18;
	}

	[SerializeField]
	[Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40005F6")]
	private Animator m_Animator;

	[Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40005F7")]
	public AudioClip pnlMusic;

	[SerializeField]
	[Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40005F8")]
	private Dictionary<int, Button> m_SelectedButtonList;

	[Token(Token = "0x40005F9")]
	[SerializeField]
	[Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private Dictionary<int, GameObject> m_ShowWindows;

	[SerializeField]
	[Token(Token = "0x40005FA")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private GameObject m_GmButtons;

	[Token(Token = "0x40005FB")]
	[SerializeField]
	[Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	private GameObject[] m_Blanks;

	[SerializeField]
	[Token(Token = "0x40005FC")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	private Text m_Version;

	[SerializeField]
	[Token(Token = "0x40005FD")]
	[Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	private Button m_BtnNSResetJAPCheck;

	[Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x40005FE")]
	private Toggle m_TglSetIfJAP;

	[Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40005FF")]
	private RecommendVersionController m_RecommendVersionTipComp;

	[Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000600")]
	private bool m_LanguageChangedDirty;

	[Token(Token = "0x4000601")]
	private const int m_GridLineCount = 5;

	[Token(Token = "0x4000602")]
	private const int m_TotalCount = 10;

	[Token(Token = "0x17000093")]
	public Dictionary<int, Button> SelectedButtonList
	{
		[Address(RVA = "0x561290", Offset = "0x55FA90", Length = "0x8")]
		[Token(Token = "0x60006FD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x86F920", Offset = "0x86E120", Length = "0x30C")]
	public override void OnAwake()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x86F8B0", Offset = "0x86E0B0", Length = "0x58")]
	private void GMButtonSwitch()
	{
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x870F30", Offset = "0x86F730", Length = "0x2F")]
	private void WeGameButtonInit()
	{
	}

	[Address(RVA = "0x86F910", Offset = "0x86E110", Length = "0xF")]
	[Token(Token = "0x6000701")]
	private void SteamButtonInit()
	{
	}

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x86F910", Offset = "0x86E110", Length = "0xF")]
	private void TapTapButtonInit()
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x86F910", Offset = "0x86E110", Length = "0xF")]
	private void IOSButtonInit()
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x86F910", Offset = "0x86E110", Length = "0xF")]
	private void GoogleButtonInit()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void NSButtonInit()
	{
	}

	[Address(RVA = "0x870C50", Offset = "0x86F450", Length = "0xD1")]
	[Token(Token = "0x6000706")]
	private void SetButtonVisual(int index, bool enable)
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x870B90", Offset = "0x86F390", Length = "0xB2")]
	private void SetBlankVisual(int index, bool enable)
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x86FC30", Offset = "0x86E430", Length = "0x2EC")]
	private void OnClicked(Button btn, int btnIndex)
	{
	}

	[Address(RVA = "0x8709B0", Offset = "0x86F1B0", Length = "0x68")]
	[Token(Token = "0x6000709")]
	private void SendTAData(string str)
	{
	}

	[Address(RVA = "0x870540", Offset = "0x86ED40", Length = "0xBA")]
	[Token(Token = "0x600070A")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x870600", Offset = "0x86EE00", Length = "0x8")]
	[Token(Token = "0x600070B")]
	private void OnLanguageChanged(int languageIndex)
	{
	}

	[Address(RVA = "0x8702C0", Offset = "0x86EAC0", Length = "0x27E")]
	[Token(Token = "0x600070C")]
	private void OnGetRecommendVersion(bool showRecommendSign)
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x870730", Offset = "0x86EF30", Length = "0x12F")]
	private void RefreshAnchorModeBtnState()
	{
	}

	[Address(RVA = "0x870060", Offset = "0x86E860", Length = "0x25A")]
	[Token(Token = "0x600070E")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x870860", Offset = "0x86F060", Length = "0x149")]
	[Token(Token = "0x600070F")]
	private void RefreshShopGoods()
	{
	}

	[Address(RVA = "0x86F7F0", Offset = "0x86DFF0", Length = "0xB7")]
	[Token(Token = "0x6000710")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0x870DE0", Offset = "0x86F5E0", Length = "0x14F")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x870610", Offset = "0x86EE10", Length = "0x110")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x870D30", Offset = "0x86F530", Length = "0xA9")]
	[Token(Token = "0x6000713")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Address(RVA = "0x86FF40", Offset = "0x86E740", Length = "0x118")]
	[Token(Token = "0x6000714")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x870A20", Offset = "0x86F220", Length = "0x162")]
	[Token(Token = "0x6000715")]
	private void SetAutoFight(bool isOn)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x6000716")]
	public OptionSelect()
	{
	}
}
