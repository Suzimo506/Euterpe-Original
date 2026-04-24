using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.PeroTools.UI;
using Assets.Scripts.Purchase;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000941")]
public class PnlDlcJustAsPlanned : DLCInfoBaseControl
{
	[Token(Token = "0x2000DB7")]
	private class DisplayInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4004092")]
		public string source;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4004093")]
		public string description;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4004094")]
		public string extra;

		[Token(Token = "0x600657C")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public DisplayInfo()
		{
		}
	}

	[Token(Token = "0x2000DB8")]
	private class DisplayFsv
	{
		[Token(Token = "0x4004095")]
		[FieldOffset(Offset = "0x10")]
		private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_Fsv;

		[Token(Token = "0x4004096")]
		[FieldOffset(Offset = "0x18")]
		private LongSongNameController m_Description;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4004097")]
		private Transform[] m_Cells;

		[Token(Token = "0x4004098")]
		[FieldOffset(Offset = "0x28")]
		private Image[] m_CellImage;

		[Token(Token = "0x4004099")]
		[FieldOffset(Offset = "0x30")]
		private Button m_Button;

		[Token(Token = "0x400409A")]
		[FieldOffset(Offset = "0x38")]
		private List<DisplayInfo> m_Source;

		[Token(Token = "0x400409B")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_MoveNext;

		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400409C")]
		private bool m_IsScrolling;

		[Token(Token = "0x17000B1F")]
		public int fsvIndex
		{
			[Address(RVA = "0x6F50D0", Offset = "0x6F38D0", Length = "0x4")]
			[Token(Token = "0x600657D")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Address(RVA = "0x821260", Offset = "0x81FA60", Length = "0x4")]
			[Token(Token = "0x600657E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000B20")]
		public DisplayInfo display
		{
			[Address(RVA = "0x821140", Offset = "0x81F940", Length = "0x72")]
			[Token(Token = "0x6006581")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000A1")]
		public event Action<bool> onClick
		{
			[Address(RVA = "0x8210A0", Offset = "0x81F8A0", Length = "0x9E")]
			[Token(Token = "0x600657F")]
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			[Address(RVA = "0x8211C0", Offset = "0x81F9C0", Length = "0x9E")]
			[Token(Token = "0x6006580")]
			remove
			{
			}
		}

		[Token(Token = "0x6006582")]
		[Address(RVA = "0x820CF0", Offset = "0x81F4F0", Length = "0x3A5")]
		public DisplayFsv(Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fsv, LongSongNameController description, Button button)
		{
		}

		[Token(Token = "0x6006583")]
		[Address(RVA = "0x820640", Offset = "0x81EE40", Length = "0x53E")]
		private void OnItemChange()
		{
		}

		[Token(Token = "0x6006584")]
		[Address(RVA = "0x820B80", Offset = "0x81F380", Length = "0xD0")]
		public void Reset(List<DisplayInfo> source, int index)
		{
		}

		[Address(RVA = "0x820C60", Offset = "0x81F460", Length = "0x5B")]
		[Token(Token = "0x6006585")]
		public void Stop()
		{
		}

		[Address(RVA = "0x820520", Offset = "0x81ED20", Length = "0x114")]
		[Token(Token = "0x6006586")]
		private void MoveNext(bool force)
		{
		}

		[Token(Token = "0x6006587")]
		[Address(RVA = "0x820440", Offset = "0x81EC40", Length = "0xDD")]
		private void AutoMoveNext()
		{
		}
	}

	[Token(Token = "0x4003204")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x949E0", Offset = "0x93DE0")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView character;

	[Token(Token = "0x4003205")]
	[FieldOffset(Offset = "0x68")]
	public Button btnCharacter;

	[Token(Token = "0x4003206")]
	[FieldOffset(Offset = "0x70")]
	public LongSongNameController characterTitleController;

	[Token(Token = "0x4003207")]
	[FieldOffset(Offset = "0x78")]
	public Animator characterAnim;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x94B60", Offset = "0x93F60")]
	[Token(Token = "0x4003208")]
	[FieldOffset(Offset = "0x80")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView elfin;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4003209")]
	public Button btnElfin;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400320A")]
	public LongSongNameController elfinTitleController;

	[Token(Token = "0x400320B")]
	[FieldOffset(Offset = "0x98")]
	public Animator elfinAnim;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400320C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x94D10", Offset = "0x94110")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView interlude;

	[Token(Token = "0x400320D")]
	[FieldOffset(Offset = "0xA8")]
	public Button btnInterlude;

	[Token(Token = "0x400320E")]
	[FieldOffset(Offset = "0xB0")]
	public Animator interludeAnim;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x94E80", Offset = "0x94280")]
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400320F")]
	public LongSongNameController songNameController;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4003210")]
	public LongSongNameController albumNameController;

	[Token(Token = "0x4003211")]
	[FieldOffset(Offset = "0xC8")]
	public Button btnNextSong;

	[Token(Token = "0x4003212")]
	[FieldOffset(Offset = "0xD0")]
	public Button btnPreviousSong;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4003213")]
	private Animator m_BtnNextSongAnim;

	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4003214")]
	private Animator m_BtnPreviousSongAnim;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4003215")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95050", Offset = "0x94450")]
	public GameObject imgDiscount;

	[SerializeField]
	[Token(Token = "0x4003216")]
	[FieldOffset(Offset = "0xF0")]
	private PriceTxtDisplay m_Price;

	[Token(Token = "0x4003217")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x952A0", Offset = "0x946A0")]
	[FieldOffset(Offset = "0xF8")]
	public Button btnPurchase;

	[Token(Token = "0x4003218")]
	[FieldOffset(Offset = "0x100")]
	public Button btnRestorePurchase;

	[Token(Token = "0x4003219")]
	[FieldOffset(Offset = "0x108")]
	public Button btnPurchased;

	[SerializeField]
	[Token(Token = "0x400321A")]
	[FieldOffset(Offset = "0x110")]
	private BtnIAP m_BtnPurchaseIAP;

	[SerializeField]
	[Token(Token = "0x400321B")]
	[FieldOffset(Offset = "0x118")]
	private BtnIAP m_BtnRestorePurchaseIAP;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400321C")]
	public GameObject purchaseMask;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400321D")]
	[SerializeField]
	private Button m_BtnQA;

	[SerializeField]
	[Token(Token = "0x400321E")]
	[FieldOffset(Offset = "0x130")]
	private VipPrefabSelector m_VipPrefabSelector;

	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x95830", Offset = "0x94C30")]
	[Token(Token = "0x400321F")]
	[FieldOffset(Offset = "0x138")]
	public Image achvIconBg;

	[Token(Token = "0x4003220")]
	[FieldOffset(Offset = "0x140")]
	public GameObject achvIcon;

	[Token(Token = "0x4003221")]
	[FieldOffset(Offset = "0x148")]
	private Button m_BtnAchvIcon;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4003222")]
	public bool isHideAchvIconBg;

	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4003223")]
	private int m_WhiteAnim;

	[Token(Token = "0x4003224")]
	[FieldOffset(Offset = "0x158")]
	private bool m_IsDisplayInfosPlaying;

	[Token(Token = "0x4003225")]
	[FieldOffset(Offset = "0x160")]
	private DisplayFsv m_CharacterDisplay;

	[Token(Token = "0x4003226")]
	[FieldOffset(Offset = "0x168")]
	private DisplayFsv m_ElfinDisplay;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4003227")]
	private DisplayFsv m_InterludeDisplay;

	[Token(Token = "0x4003228")]
	private static int m_CharacterDisplayIndex;

	[Token(Token = "0x4003229")]
	private static int m_ElfinDisplayIndex;

	[Token(Token = "0x400322A")]
	private static int m_InterludeDisplayIndex;

	[Token(Token = "0x400322B")]
	private static List<DisplayInfo> m_DisplayCharacter;

	[Token(Token = "0x400322C")]
	private static List<DisplayInfo> m_DisplayElfin;

	[Token(Token = "0x400322D")]
	private static List<DisplayInfo> m_DisplayInterlude;

	[Token(Token = "0x400322E")]
	[FieldOffset(Offset = "0x178")]
	private bool m_IsUnlockAll;

	[Token(Token = "0x400322F")]
	private const string m_DisplayRegexPattern = "[\\s-\\.]";

	[Token(Token = "0x4003230")]
	private static bool s_ForceRefresh;

	[Token(Token = "0x4003231")]
	[FieldOffset(Offset = "0x180")]
	private PnlDlc m_Pnldlc;

	[SerializeField]
	[Token(Token = "0x4003232")]
	private static Transform S_DisplayFsvCellCacheTransform;

	[Token(Token = "0x4003233")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4003234")]
	private Dictionary<string, JArray> m_JsonCache;

	[Token(Token = "0x4003235")]
	private static Dictionary<string, GameObject> m_RefactorAssetCache;

	[Token(Token = "0x4003236")]
	private static Dictionary<string, GameObject> m_AssetCache;

	[Token(Token = "0x4003237")]
	private static Dictionary<string, Queue<GameObject>> m_AssetPool;

	[Token(Token = "0x4003238")]
	[FieldOffset(Offset = "0x190")]
	private int m_ClickPurchasedCount;

	[Token(Token = "0x6005400")]
	[Address(RVA = "0x829F70", Offset = "0x828770", Length = "0x57")]
	public static void SetDirty()
	{
	}

	[Token(Token = "0x6005401")]
	[Address(RVA = "0x828D60", Offset = "0x827560", Length = "0x2C")]
	private void OnTransactionCompleted(TransactionResult result)
	{
	}

	[Token(Token = "0x6005402")]
	[Address(RVA = "0x8279A0", Offset = "0x8261A0", Length = "0x8A8")]
	public override void Init(PnlDlc pnlDlc)
	{
	}

	[Address(RVA = "0x8285A0", Offset = "0x826DA0", Length = "0xF7")]
	[Token(Token = "0x6005403")]
	private void OnClickJustAsPlannedQA()
	{
	}

	[Token(Token = "0x6005404")]
	[Address(RVA = "0x828C00", Offset = "0x827400", Length = "0xD5")]
	public override void OnFinalItemChange(bool isSelected)
	{
	}

	[Token(Token = "0x6005405")]
	[Address(RVA = "0x828BF0", Offset = "0x8273F0", Length = "0xA")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005406")]
	[Address(RVA = "0x828950", Offset = "0x827150", Length = "0x297")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x829D30", Offset = "0x828530", Length = "0x102")]
	[Token(Token = "0x6005407")]
	public void Refresh(bool force = false)
	{
	}

	[Address(RVA = "0x829780", Offset = "0x827F80", Length = "0x5AE")]
	[Token(Token = "0x6005408")]
	private void Refresh(DateTime utcTime, bool force = false)
	{
	}

	[Address(RVA = "0x829030", Offset = "0x827830", Length = "0x57")]
	[Token(Token = "0x6005409")]
	private void RefreshAchvIcon(bool isUnlockAll)
	{
	}

	[Token(Token = "0x600540A")]
	[Address(RVA = "0x829370", Offset = "0x827B70", Length = "0x1B9")]
	private void RefreshDiscount(bool isUnlockAll, DateTime utcTime)
	{
	}

	[Token(Token = "0x600540B")]
	[Address(RVA = "0x826EB0", Offset = "0x8256B0", Length = "0x2CA")]
	private void DisplayInfoRefresh_Interlude()
	{
	}

	[Token(Token = "0x600540C")]
	[Address(RVA = "0x826D60", Offset = "0x825560", Length = "0x140")]
	private void DisplayInfoRefresh_Elfin()
	{
	}

	[Address(RVA = "0x826C20", Offset = "0x825420", Length = "0x13F")]
	[Token(Token = "0x600540D")]
	private void DisplayInfoRefresh_Character()
	{
	}

	[Token(Token = "0x600540E")]
	[Address(RVA = "0x8272E0", Offset = "0x825AE0", Length = "0xA")]
	private void ForceStop()
	{
	}

	[Token(Token = "0x600540F")]
	[Address(RVA = "0x829FD0", Offset = "0x8287D0", Length = "0x147")]
	public void Stop(bool force = false)
	{
	}

	[Token(Token = "0x6005410")]
	[Address(RVA = "0x828250", Offset = "0x826A50", Length = "0x34A")]
	private bool IsNeedDisplay(string type, int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x827180", Offset = "0x825980", Length = "0x151")]
	[Token(Token = "0x6005411")]
	private bool ExcludeJustAsPlannedCheck(string type, int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x82A5F0", Offset = "0x828DF0", Length = "0xD9")]
	[Token(Token = "0x6005412")]
	private bool isItemTimeout(string type, int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x826370", Offset = "0x824B70", Length = "0x2D0")]
	[Token(Token = "0x6005413")]
	private void AddCharacter(bool isShowAll = false)
	{
	}

	[Address(RVA = "0x826650", Offset = "0x824E50", Length = "0x25D")]
	[Token(Token = "0x6005414")]
	private void AddElfin(bool isShowAll = false)
	{
	}

	[Token(Token = "0x6005415")]
	[Address(RVA = "0x8268B0", Offset = "0x8250B0", Length = "0x2EE")]
	private void AddInterlude(bool isShowAll = false)
	{
	}

	[Address(RVA = "0x827870", Offset = "0x826070", Length = "0x125")]
	[Token(Token = "0x6005416")]
	private static Sprite GetSprite(string key)
	{
		return null;
	}

	[Address(RVA = "0x8277B0", Offset = "0x825FB0", Length = "0xB2")]
	[Token(Token = "0x6005417")]
	private JArray GetJson(string key)
	{
		return null;
	}

	[Address(RVA = "0x8272F0", Offset = "0x825AF0", Length = "0x4BD")]
	[Token(Token = "0x6005418")]
	private static void GetAsset(string key, Transform parent)
	{
	}

	[Token(Token = "0x6005419")]
	[Address(RVA = "0x829E40", Offset = "0x828640", Length = "0x124")]
	private static void ReleaseAsset(GameObject obj)
	{
	}

	[Token(Token = "0x600541A")]
	[Address(RVA = "0x828DF0", Offset = "0x8275F0", Length = "0x52")]
	private void PlayPreviousDemo()
	{
	}

	[Token(Token = "0x600541B")]
	[Address(RVA = "0x828D90", Offset = "0x827590", Length = "0x52")]
	private void PlayNextDemo()
	{
	}

	[Token(Token = "0x600541C")]
	[Address(RVA = "0x828CE0", Offset = "0x8274E0", Length = "0xF")]
	private void OnPnlDlcPlayNewDemo(PnlDlcMusicInfo pnlDlcMusicInfo)
	{
	}

	[Address(RVA = "0x829090", Offset = "0x827890", Length = "0x2D6")]
	[Token(Token = "0x600541D")]
	private void RefreshDemoPlayerDisplay(string albumInfo, string musicInfo)
	{
	}

	[Token(Token = "0x600541E")]
	[Address(RVA = "0x829530", Offset = "0x827D30", Length = "0x24E")]
	private void RefreshPrice(Product product, DateTime utcTime)
	{
	}

	[Address(RVA = "0x828CF0", Offset = "0x8274F0", Length = "0x61")]
	[Token(Token = "0x600541F")]
	private void OnRestoreClicked()
	{
	}

	[Token(Token = "0x6005420")]
	[Address(RVA = "0x8286A0", Offset = "0x826EA0", Length = "0xBB")]
	private void OnClickPurchase()
	{
	}

	[Token(Token = "0x6005421")]
	[Address(RVA = "0x828760", Offset = "0x826F60", Length = "0x1EE")]
	private void OnClickPurchased()
	{
	}

	[Token(Token = "0x6005422")]
	[Address(RVA = "0x828E50", Offset = "0x827650", Length = "0x1D5")]
	private void RandomList(ref List<DisplayInfo> source, DisplayInfo last, int topIndex)
	{
	}

	[Token(Token = "0x6005423")]
	[Address(RVA = "0x826BA0", Offset = "0x8253A0", Length = "0x71")]
	private void Awake()
	{
	}

	[Address(RVA = "0x82A570", Offset = "0x828D70", Length = "0x80")]
	[Token(Token = "0x6005424")]
	public PnlDlcJustAsPlanned()
	{
	}
}
