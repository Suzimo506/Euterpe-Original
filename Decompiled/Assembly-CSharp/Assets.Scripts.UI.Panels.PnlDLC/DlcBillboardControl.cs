using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using MEC;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000923")]
public class DlcBillboardControl : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003134")]
	[SerializeField]
	private GameObject m_PlayMask;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4003135")]
	private Image m_BgImage;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4003136")]
	[SerializeField]
	private Image m_Img;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003137")]
	private Button m_Button;

	[Token(Token = "0x4003138")]
	[FieldOffset(Offset = "0x38")]
	private int m_JsonIndex;

	[SerializeField]
	[Token(Token = "0x4003139")]
	[FieldOffset(Offset = "0x3C")]
	private int m_ButtonIndex;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400313A")]
	private DLCInfoSubControl m_Parent;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400313B")]
	private AudioManager m_AudioManager;

	[Token(Token = "0x400313C")]
	[FieldOffset(Offset = "0x50")]
	private DlcBillboardInfo m_DlcBillboardInfo;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400313D")]
	private string m_Destription;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400313E")]
	private List<CarouselInfo> m_CurCarouselInfos;

	[Token(Token = "0x400313F")]
	[FieldOffset(Offset = "0x68")]
	private DlcBillboardControl m_RelevanceBillboardControl;

	[Token(Token = "0x4003140")]
	[FieldOffset(Offset = "0x70")]
	private float m_AutoPlayInterval;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4003142")]
	private Coroutine m_MoveNext;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4003143")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_BillBoardFsv;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4003144")]
	private bool m_IsScrolling;

	[Token(Token = "0x4003145")]
	[FieldOffset(Offset = "0x8C")]
	private int m_FsvIndex;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4003146")]
	private Transform[] m_Cells;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4003147")]
	private Image[] m_CellImage;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4003148")]
	private List<string> m_AutoPlayImgs;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4003149")]
	private bool m_IsParentSubControlSelect;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400314A")]
	private Coroutine m_ShowInfoCoroutine;

	[Token(Token = "0x400314B")]
	[FieldOffset(Offset = "0xB8")]
	private CoroutineHandle m_AutoChangeMusicCoroutine;

	[Token(Token = "0x400314C")]
	[FieldOffset(Offset = "0xBC")]
	private float m_ShowBillInfoTime;

	[Token(Token = "0x400314D")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x400314E")]
	private static Dictionary<string, AudioClip> m_AudioClipCache;

	[Token(Token = "0x170008C0")]
	private SingelCarouseInfo m_CurSingleCarouseInfo
	{
		[Address(RVA = "0x42C9D0", Offset = "0x42B1D0", Length = "0x22")]
		[Token(Token = "0x60052DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C1")]
	public int disPlayIndex
	{
		[Token(Token = "0x60052DD")]
		[CompilerGenerated]
		[Address(RVA = "0x42C7D0", Offset = "0x42AFD0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x42CA10", Offset = "0x42B210", Length = "0x4")]
		[Token(Token = "0x60052DE")]
		private set
		{
		}
	}

	[Token(Token = "0x170008C2")]
	public int fsvIndex
	{
		[Token(Token = "0x60052DF")]
		[Address(RVA = "0x42C7E0", Offset = "0x42AFE0", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x42CA20", Offset = "0x42B220", Length = "0x22")]
		[Token(Token = "0x60052E0")]
		private set
		{
		}
	}

	[Token(Token = "0x170008C3")]
	private int m_CurBgmMode
	{
		[Address(RVA = "0x42C7F0", Offset = "0x42AFF0", Length = "0x96")]
		[Token(Token = "0x60052E1")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170008C4")]
	private BillboardType m_CurBillboardType
	{
		[Address(RVA = "0x42C980", Offset = "0x42B180", Length = "0x48")]
		[Token(Token = "0x60052E2")]
		get
		{
			return default(BillboardType);
		}
	}

	[Token(Token = "0x170008C5")]
	private string m_CurBgmName
	{
		[Token(Token = "0x60052E3")]
		[Address(RVA = "0x42C890", Offset = "0x42B090", Length = "0xE7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008C6")]
	private bool m_IsSelect
	{
		[Token(Token = "0x60052E4")]
		[Address(RVA = "0x42CA00", Offset = "0x42B200", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x42ADE0", Offset = "0x4295E0", Length = "0x25")]
	[Token(Token = "0x60052E5")]
	public void Init(DLCInfoSubControl parent)
	{
	}

	[Token(Token = "0x60052E6")]
	[Address(RVA = "0x42AB00", Offset = "0x429300", Length = "0x2DF")]
	private void InitFsv()
	{
	}

	[Token(Token = "0x60052E7")]
	[Address(RVA = "0x42B350", Offset = "0x429B50", Length = "0x27")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60052E8")]
	[Address(RVA = "0x42C480", Offset = "0x42AC80", Length = "0x1E")]
	public void SetEnable(bool enable)
	{
	}

	[Address(RVA = "0x42A790", Offset = "0x428F90", Length = "0x44")]
	[Token(Token = "0x60052E9")]
	private void Awake()
	{
	}

	[Token(Token = "0x60052EA")]
	[Address(RVA = "0x42C280", Offset = "0x42AA80", Length = "0x1FA")]
	public void SetBillboard(int jsonIndex, DlcBillboardInfo info, DlcBillboardControl relevanceBillboardControl = null)
	{
	}

	[Address(RVA = "0x42C0F0", Offset = "0x42A8F0", Length = "0x185")]
	[Token(Token = "0x60052EB")]
	public void SetBillboardUI(int jsonIndex, DlcUIExtensionInfo info)
	{
	}

	[Address(RVA = "0x42B9C0", Offset = "0x42A1C0", Length = "0x663")]
	[Token(Token = "0x60052EC")]
	public void ResetDisPlay(bool quickChange = false)
	{
	}

	[Address(RVA = "0x42A5E0", Offset = "0x428DE0", Length = "0x1A5")]
	[Token(Token = "0x60052ED")]
	private void AutoMoveNext()
	{
	}

	[Address(RVA = "0x42AE10", Offset = "0x429610", Length = "0x1A6")]
	[Token(Token = "0x60052EE")]
	private void MoveNext(bool isFirst = false)
	{
	}

	[Token(Token = "0x60052EF")]
	[Address(RVA = "0x42B380", Offset = "0x429B80", Length = "0x3FB")]
	private void OnItemChange()
	{
	}

	[Token(Token = "0x60052F0")]
	[Address(RVA = "0x42AFC0", Offset = "0x4297C0", Length = "0x19D")]
	private void OnBtnClicked()
	{
	}

	[Address(RVA = "0x42B780", Offset = "0x429F80", Length = "0x23D")]
	[Token(Token = "0x60052F1")]
	private void PlayLoopBgm(string bgmName)
	{
	}

	[Address(RVA = "0x42C030", Offset = "0x42A830", Length = "0xBC")]
	[Token(Token = "0x60052F2")]
	private void SetBillInfoText()
	{
	}

	[Token(Token = "0x60052F3")]
	[Address(RVA = "0x42A7E0", Offset = "0x428FE0", Length = "0xBE")]
	private void ClearDisplayChangeItem()
	{
	}

	[Address(RVA = "0x42C610", Offset = "0x42AE10", Length = "0x5B")]
	[Token(Token = "0x60052F4")]
	public void StopAutoMoveNext()
	{
	}

	[Token(Token = "0x60052F5")]
	[Address(RVA = "0x42C4A0", Offset = "0x42ACA0", Length = "0x7")]
	public void SetSubControlSelect(bool select)
	{
	}

	[Address(RVA = "0x42B1F0", Offset = "0x4299F0", Length = "0x15C")]
	[Token(Token = "0x60052F6")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x42C520", Offset = "0x42AD20", Length = "0xEF")]
	[Token(Token = "0x60052F7")]
	public void ShowBillInfo()
	{
	}

	[Token(Token = "0x60052F8")]
	[Address(RVA = "0x42C4B0", Offset = "0x42ACB0", Length = "0x65")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x8A4C0", Offset = "0x898C0")]
	private IEnumerator ShowBillInfoCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60052F9")]
	[Address(RVA = "0x42A9D0", Offset = "0x4291D0", Length = "0x123")]
	private static Sprite GetSprite(string key)
	{
		return null;
	}

	[Address(RVA = "0x42A8A0", Offset = "0x4290A0", Length = "0x125")]
	[Token(Token = "0x60052FA")]
	private static AudioClip GetAudioClip(string key)
	{
		return null;
	}

	[Address(RVA = "0x42B160", Offset = "0x429960", Length = "0x8E")]
	[Token(Token = "0x60052FB")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60052FC")]
	[Address(RVA = "0x42C7B0", Offset = "0x42AFB0", Length = "0x11")]
	public DlcBillboardControl()
	{
	}
}
