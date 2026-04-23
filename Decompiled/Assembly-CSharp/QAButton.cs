using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000193")]
public class QAButton : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009E0")]
	public RectTransform answer;

	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x20")]
	public Button button;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009E2")]
	public RectTransform imgSelect;

	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x30")]
	private float m_AnswerSpace;

	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x34")]
	public Color highlight;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40009E5")]
	public Color normal;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40009E6")]
	public AudioClip onClick;

	[Token(Token = "0x40009E7")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform m_Content;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40009E8")]
	private RectTransform m_Rect;

	[Token(Token = "0x40009E9")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 m_ContentSize;

	[Token(Token = "0x40009EA")]
	[FieldOffset(Offset = "0x78")]
	private bool m_Show;

	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x80")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x88")]
	private Text m_Title;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40009ED")]
	private bool m_InAnim;

	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x91")]
	public bool alwaysExpand;

	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x56AA30", Offset = "0x569230", Length = "0x8")]
	public bool inAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x569CE0", Offset = "0x5684E0", Length = "0x10B")]
	protected virtual void Awake()
	{
	}

	[Address(RVA = "0x56A2D0", Offset = "0x568AD0", Length = "0x159")]
	[Token(Token = "0x6000B5E")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x56A2B0", Offset = "0x568AB0", Length = "0x11")]
	[Token(Token = "0x6000B5F")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x569DF0", Offset = "0x5685F0", Length = "0x4B8")]
	public void OnClick(bool playSound = true)
	{
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x56A430", Offset = "0x568C30", Length = "0x12E")]
	public void SetSelect(bool enable)
	{
	}

	[Address(RVA = "0x56A560", Offset = "0x568D60", Length = "0x97")]
	[Token(Token = "0x6000B62")]
	public void SetTitleNumber(string number)
	{
	}

	[Address(RVA = "0x56A9B0", Offset = "0x5691B0", Length = "0x7A")]
	[Token(Token = "0x6000B63")]
	public QAButton()
	{
	}
}
