using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018B")]
public class PeroPeroTopPainterWelcome : MonoBehaviour
{
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x18")]
	public Button btnOnPlayAnim;

	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x20")]
	public bool isUISystem;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009AB")]
	private Animator m_Animator;

	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsClick;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009AD")]
	private float m_AudioVolume;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009AE")]
	private bool m_IsDone;

	[Address(RVA = "0x4F7020", Offset = "0x4F5820", Length = "0x118")]
	[Token(Token = "0x6000B2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B2D")]
	[Address(RVA = "0x4F6DD0", Offset = "0x4F55D0", Length = "0x89")]
	private void Init()
	{
	}

	[Token(Token = "0x6000B2E")]
	[Address(RVA = "0x4F6E60", Offset = "0x4F5660", Length = "0x164")]
	private void OnClickPlayPeroPeroTopPainter()
	{
	}

	[Address(RVA = "0x4F6FD0", Offset = "0x4F57D0", Length = "0x43")]
	[Token(Token = "0x6000B2F")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000B30")]
	public PeroPeroTopPainterWelcome()
	{
	}
}
