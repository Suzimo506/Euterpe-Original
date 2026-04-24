using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.UI.Tips;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000171")]
public class BtnLikeForGameMain : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400091B")]
	public Image holdImg;

	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject imgLike;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400091D")]
	public GameObject imgHide;

	[Token(Token = "0x400091E")]
	[FieldOffset(Offset = "0x30")]
	private MusicInfo m_SelectedMusic;

	[Token(Token = "0x400091F")]
	[FieldOffset(Offset = "0x38")]
	private Effect m_ParTglLikes;

	[Token(Token = "0x4000920")]
	[FieldOffset(Offset = "0x40")]
	private Effect m_ParTglDisLikes;

	[SerializeField]
	[Token(Token = "0x4000921")]
	[FieldOffset(Offset = "0x48")]
	private string m_ButtonName;

	[SerializeField]
	[Token(Token = "0x4000922")]
	[FieldOffset(Offset = "0x50")]
	private float m_HoldTime;

	[Token(Token = "0x4000923")]
	[FieldOffset(Offset = "0x54")]
	public bool isPnlVictory;

	[Token(Token = "0x4000924")]
	private const string fail = "PnlFail";

	[Token(Token = "0x4000925")]
	private const string victory = "PnlVictory";

	[Token(Token = "0x4000926")]
	[FieldOffset(Offset = "0x58")]
	private AbstractMessageBox m_HideMsg;

	[Token(Token = "0x4000927")]
	[FieldOffset(Offset = "0x60")]
	private AbstractMessageBox m_CancelHideMsg;

	[Attribute(Name = "HeaderAttribute", RVA = "0x394A0", Offset = "0x388A0")]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000928")]
	private bool m_IsPointDown;

	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000929")]
	private bool m_IsBeginHoldAnim;

	[Token(Token = "0x400092A")]
	[FieldOffset(Offset = "0x70")]
	private Button m_Button;

	[Token(Token = "0x400092B")]
	[FieldOffset(Offset = "0x78")]
	private Image m_Img;

	[Token(Token = "0x400092C")]
	[FieldOffset(Offset = "0x80")]
	private float m_LongHoldTimer;

	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400092D")]
	private bool m_IsHide;

	[Token(Token = "0x400092E")]
	[FieldOffset(Offset = "0x85")]
	private bool m_IsCollection;

	[Token(Token = "0x400092F")]
	[FieldOffset(Offset = "0x86")]
	private bool m_IsClickHide;

	[Token(Token = "0x170000DB")]
	private bool isOn
	{
		[Address(RVA = "0x461F50", Offset = "0x460750", Length = "0x13")]
		[Token(Token = "0x6000A93")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x460C50", Offset = "0x45F450", Length = "0x65")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x461720", Offset = "0x45FF20", Length = "0x50B")]
	private void Start()
	{
	}

	[Address(RVA = "0x460CC0", Offset = "0x45F4C0", Length = "0x1A4")]
	[Token(Token = "0x6000A96")]
	private void InitMsg()
	{
	}

	[Address(RVA = "0x460F40", Offset = "0x45F740", Length = "0x8")]
	[Token(Token = "0x6000A97")]
	public void OnHideMsgShow()
	{
	}

	[Address(RVA = "0x460F30", Offset = "0x45F730", Length = "0x8")]
	[Token(Token = "0x6000A98")]
	public void OnHideMsgClose()
	{
	}

	[Address(RVA = "0x461C30", Offset = "0x460430", Length = "0x43")]
	[Token(Token = "0x6000A99")]
	private void UpdateIcon()
	{
	}

	[Address(RVA = "0x461250", Offset = "0x45FA50", Length = "0x355")]
	[Token(Token = "0x6000A9A")]
	private void OnVictoryBtnClicked(bool state)
	{
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x4609F0", Offset = "0x45F1F0", Length = "0x256")]
	private void AddCollection()
	{
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x4615B0", Offset = "0x45FDB0", Length = "0x162")]
	private void RemoveCollection()
	{
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x460F50", Offset = "0x45F750", Length = "0x1D2")]
	private void OnHideMusic()
	{
	}

	[Token(Token = "0x6000A9E")]
	[Address(RVA = "0x461140", Offset = "0x45F940", Length = "0x105")]
	private void OnRemoveHideMusic()
	{
	}

	[Address(RVA = "0x460E70", Offset = "0x45F670", Length = "0x5")]
	[Token(Token = "0x6000A9F")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	[Address(RVA = "0x461130", Offset = "0x45F930", Length = "0x7")]
	[Token(Token = "0x6000AA0")]
	public void OnPointerUp(PointerEventData data)
	{
	}

	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x460E70", Offset = "0x45F670", Length = "0x5")]
	private void KeyPress()
	{
	}

	[Address(RVA = "0x460E80", Offset = "0x45F680", Length = "0xA6")]
	[Token(Token = "0x6000AA2")]
	private void KeyUp()
	{
	}

	[Address(RVA = "0x461C80", Offset = "0x460480", Length = "0x27B")]
	[Token(Token = "0x6000AA3")]
	private void Update()
	{
	}

	[Address(RVA = "0x461F00", Offset = "0x460700", Length = "0x4D")]
	[Token(Token = "0x6000AA4")]
	public BtnLikeForGameMain()
	{
	}
}
