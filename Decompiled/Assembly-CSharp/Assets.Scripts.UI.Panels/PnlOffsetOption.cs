using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.UI.Tips;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D9")]
public class PnlOffsetOption : MonoBehaviour
{
	[Token(Token = "0x4002E4D")]
	[FieldOffset(Offset = "0x18")]
	public Transform start;

	[Token(Token = "0x4002E4E")]
	[FieldOffset(Offset = "0x20")]
	public Transform end;

	[Token(Token = "0x4002E4F")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform touchRect;

	[Token(Token = "0x4002E50")]
	[FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x4002E51")]
	[FieldOffset(Offset = "0x38")]
	public GameObject nonius;

	[Token(Token = "0x4002E52")]
	[FieldOffset(Offset = "0x40")]
	public GameObject fadeObject;

	[Token(Token = "0x4002E53")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip audioClip;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002E54")]
	public Button btnNext;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002E55")]
	public Button btnPre;

	[Token(Token = "0x4002E56")]
	[FieldOffset(Offset = "0x60")]
	public Button tipButton;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002E57")]
	public Text text;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002E58")]
	public Transform line;

	[Token(Token = "0x4002E59")]
	[FieldOffset(Offset = "0x78")]
	public GameObject tip;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002E5A")]
	public Button btnOffset;

	[Token(Token = "0x4002E5B")]
	[FieldOffset(Offset = "0x88")]
	public GameObject title;

	[Token(Token = "0x4002E5C")]
	[FieldOffset(Offset = "0x90")]
	public GameObject titleTvMode;

	[Token(Token = "0x4002E5D")]
	[FieldOffset(Offset = "0x98")]
	public InputField offsetInput;

	[Token(Token = "0x4002E5E")]
	[FieldOffset(Offset = "0xA0")]
	private string originalValue;

	[SerializeField]
	[Token(Token = "0x4002E5F")]
	[FieldOffset(Offset = "0xA8")]
	private Button m_BtnQuestion;

	[Token(Token = "0x4002E60")]
	[FieldOffset(Offset = "0xB0")]
	private Timer m_Timer;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002E61")]
	private int m_Offset;

	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4002E62")]
	public bool isTvMode;

	[Token(Token = "0x4002E63")]
	private const int max_offset_value = 1000;

	[Token(Token = "0x4002E64")]
	[FieldOffset(Offset = "0xC0")]
	private float m_Acceleration;

	[Token(Token = "0x4002E65")]
	[FieldOffset(Offset = "0xC4")]
	private float m_AccelerationTimer;

	[Token(Token = "0x4002E66")]
	[FieldOffset(Offset = "0xC8")]
	private float m_LineDragX;

	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x4002E67")]
	[HideInInspector]
	public bool isLineDraging;

	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4002E68")]
	public AudioClip optionBgmClip;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002E69")]
	private Tween m_Tween;

	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4002E6A")]
	private AbstractMessageBox m_QuestionMessageBox;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002E6B")]
	[SerializeField]
	private AbstractMessageBox m_WebSiteMessageBox;

	[Token(Token = "0x4002E6C")]
	[SerializeField]
	[FieldOffset(Offset = "0xF0")]
	private AbstractMessageBox m_ConfirmMessageBox;

	[Token(Token = "0x6004FC2")]
	[Address(RVA = "0x6833C0", Offset = "0x681BC0", Length = "0x7")]
	public void SetTvMode(bool enable)
	{
	}

	[Token(Token = "0x6004FC3")]
	[Address(RVA = "0x682430", Offset = "0x680C30", Length = "0x132")]
	private void Awake()
	{
	}

	[Address(RVA = "0x6833D0", Offset = "0x681BD0", Length = "0x374")]
	[Token(Token = "0x6004FC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6004FC5")]
	[Address(RVA = "0x683F20", Offset = "0x682720", Length = "0x310")]
	private void ValidateInput(string input)
	{
	}

	[Token(Token = "0x6004FC6")]
	[Address(RVA = "0x683250", Offset = "0x681A50", Length = "0x16B")]
	private void SetNewOffset(decimal number)
	{
	}

	[Address(RVA = "0x6831E0", Offset = "0x6819E0", Length = "0x64")]
	[Token(Token = "0x6004FC7")]
	private void OnTipClicked()
	{
	}

	[Address(RVA = "0x682640", Offset = "0x680E40", Length = "0xBD")]
	[Token(Token = "0x6004FC8")]
	private void OnApplicationPause(bool isPause)
	{
	}

	[Token(Token = "0x6004FC9")]
	[Address(RVA = "0x683890", Offset = "0x682090", Length = "0x680")]
	private void Update()
	{
	}

	[Token(Token = "0x6004FCA")]
	[Address(RVA = "0x682ED0", Offset = "0x6816D0", Length = "0x303")]
	private void OnOffsetChanged(bool forward)
	{
	}

	[Address(RVA = "0x682A60", Offset = "0x681260", Length = "0x468")]
	[Token(Token = "0x6004FCB")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x682790", Offset = "0x680F90", Length = "0x2C9")]
	[Token(Token = "0x6004FCC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004FCD")]
	[Address(RVA = "0x682570", Offset = "0x680D70", Length = "0xC2")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004FCE")]
	[Address(RVA = "0x683750", Offset = "0x681F50", Length = "0xDC")]
	private void Tap()
	{
	}

	[Token(Token = "0x6004FCF")]
	[Address(RVA = "0x682730", Offset = "0x680F30", Length = "0x2A")]
	public void OnButtonQuestionClick()
	{
	}

	[Token(Token = "0x6004FD0")]
	[Address(RVA = "0x682760", Offset = "0x680F60", Length = "0x2A")]
	public void OnButtonWebSiteClick()
	{
	}

	[Token(Token = "0x6004FD1")]
	[Address(RVA = "0x682700", Offset = "0x680F00", Length = "0x2A")]
	public void OnButtonConfirmClick()
	{
	}

	[Token(Token = "0x6004FD2")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlOffsetOption()
	{
	}
}
