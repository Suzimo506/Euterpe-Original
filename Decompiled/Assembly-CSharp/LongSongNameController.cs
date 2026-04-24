using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000187")]
public class LongSongNameController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400098C")]
	[SerializeField]
	private Text m_MidSimpleName;

	[SerializeField]
	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x20")]
	private RectTransform m_SimpleName;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400098E")]
	[SerializeField]
	private RectTransform m_BackupName;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400098F")]
	public float m_Speed;

	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x34")]
	private float m_PreWidth;

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int m_LongBound;

	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_PlayLongAnim;

	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x40")]
	private Mask m_ParentMask;

	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x48")]
	private Image m_MaskImg;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000995")]
	[SerializeField]
	private GameObject m_LMask;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject m_RMask;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000997")]
	private Text m_TxtSimpleName;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x68")]
	private Text m_TxtBackupName;

	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x70")]
	private Coroutine m_DelayAnim;

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x78")]
	private bool m_Init;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400099B")]
	public Font specialFont;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400099C")]
	public Font normalFont;

	[SerializeField]
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x90")]
	private bool isRefreshOnStart;

	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x400099E")]
	private bool m_IsSpecialFont;

	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x94")]
	private Vector2 tempX1;

	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x9C")]
	private Vector2 tempX2;

	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x8BF550", Offset = "0x8BDD50", Length = "0xC6")]
	private void Awake()
	{
	}

	[Address(RVA = "0x8C0830", Offset = "0x8BF030", Length = "0x19")]
	[Token(Token = "0x6000B12")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x8C0580", Offset = "0x8BED80", Length = "0x229")]
	public void Refresh(bool isSpecialFont = false)
	{
	}

	[Address(RVA = "0x8BF9B0", Offset = "0x8BE1B0", Length = "0x1FF")]
	[Token(Token = "0x6000B14")]
	private void RefreshForBestFit()
	{
	}

	[Address(RVA = "0x8C0070", Offset = "0x8BE870", Length = "0x3D2")]
	[Token(Token = "0x6000B15")]
	private void RefreshText(string txt)
	{
	}

	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x8C0450", Offset = "0x8BEC50", Length = "0x12E")]
	public void Refresh(string text, bool isSpecialFont = false, float delay = 1f)
	{
	}

	[Address(RVA = "0x8BFBB0", Offset = "0x8BE3B0", Length = "0x4BF")]
	[Token(Token = "0x6000B17")]
	public void RefreshForBestFit(string txt, float delay = 1f)
	{
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x8BF620", Offset = "0x8BDE20", Length = "0x1D5")]
	private bool IsOverflowingAtMinSize(Text txt)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x8C07B0", Offset = "0x8BEFB0", Length = "0x76")]
	public void SetRect()
	{
	}

	[Address(RVA = "0x8C0850", Offset = "0x8BF050", Length = "0x1D2")]
	[Token(Token = "0x6000B1A")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x8BF800", Offset = "0x8BE000", Length = "0x6F")]
	private void Move()
	{
	}

	[Address(RVA = "0x8BF870", Offset = "0x8BE070", Length = "0x13A")]
	[Token(Token = "0x6000B1C")]
	private void PlayAnim(RectTransform x1, RectTransform x2)
	{
	}

	[Address(RVA = "0x8C0A50", Offset = "0x8BF250", Length = "0x81")]
	[Token(Token = "0x6000B1D")]
	private void Update()
	{
	}

	[Address(RVA = "0x8C0AE0", Offset = "0x8BF2E0", Length = "0xAF")]
	[Token(Token = "0x6000B1E")]
	public LongSongNameController()
	{
	}
}
