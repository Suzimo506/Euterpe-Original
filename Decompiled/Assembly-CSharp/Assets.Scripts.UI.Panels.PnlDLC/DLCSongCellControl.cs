using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200091F")]
public class DLCSongCellControl : MonoBehaviour
{
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400311C")]
	private GameObject m_MaskGameObject;

	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400311D")]
	private Image m_CoverBg;

	[SerializeField]
	[Token(Token = "0x400311E")]
	[FieldOffset(Offset = "0x28")]
	private Image m_Cover;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400311F")]
	private Text[] m_DiffTxt;

	[SerializeField]
	[Token(Token = "0x4003120")]
	[FieldOffset(Offset = "0x38")]
	private Image m_WeekFree;

	[SerializeField]
	[Token(Token = "0x4003121")]
	[FieldOffset(Offset = "0x40")]
	private Button m_Btn;

	[Token(Token = "0x4003122")]
	[SerializeField]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_AreaLocked;

	[Token(Token = "0x4003123")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text m_TxtLocked;

	[Token(Token = "0x4003124")]
	[FieldOffset(Offset = "0x58")]
	private MusicInfo m_MusicInfo;

	[Token(Token = "0x4003125")]
	[FieldOffset(Offset = "0x60")]
	private int m_ExtraIndex;

	[Token(Token = "0x4003126")]
	private const int easy = 0;

	[Token(Token = "0x4003127")]
	private const int normal = 1;

	[Token(Token = "0x4003128")]
	private const int master = 2;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4003129")]
	private DLCInfoSubControl m_Parent;

	[Token(Token = "0x170008BE")]
	public MusicInfo musicInfo
	{
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008BF")]
	public int extraIndex
	{
		[Address(RVA = "0x429C30", Offset = "0x428430", Length = "0x4")]
		[Token(Token = "0x60052C9")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60052CA")]
	[Address(RVA = "0x4294A0", Offset = "0x427CA0", Length = "0xF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60052CB")]
	[Address(RVA = "0x429950", Offset = "0x428150", Length = "0x106")]
	private void OnClicked()
	{
	}

	[Token(Token = "0x60052CC")]
	[Address(RVA = "0x4295A0", Offset = "0x427DA0", Length = "0x3A8")]
	public void Init(MusicInfo musicInfo, DLCInfoSubControl parent, string cellBg, Color cellBgColor, int extraIndex = 0)
	{
	}

	[Address(RVA = "0x429B10", Offset = "0x428310", Length = "0xFA")]
	[Token(Token = "0x60052CD")]
	private void OnLanguageChanged(int obj)
	{
	}

	[Token(Token = "0x60052CE")]
	[Address(RVA = "0x429A60", Offset = "0x428260", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60052CF")]
	[Address(RVA = "0x429C10", Offset = "0x428410", Length = "0x1E")]
	public void SetPlay(bool play)
	{
	}

	[Token(Token = "0x60052D0")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public DLCSongCellControl()
	{
	}
}
