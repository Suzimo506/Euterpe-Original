using System.Collections;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x200016F")]
public class AutoFadeBtn : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_TargetGameObject;

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400090D")]
	private float m_StartUpWaitDuration;

	[SerializeField]
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x2C")]
	private float m_FadeDuration;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400090F")]
	private bool m_IsStartUped;

	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0x38")]
	private Tween m_FadeTween;

	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x40")]
	private WaitForSeconds m_StartUpWaitForSeconds;

	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x48")]
	private WaitForSeconds m_FadeWaitForSeconds;

	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine m_ShowBtnCoroutine;

	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine m_StartUpCoroutine;

	[Token(Token = "0x6000A86")]
	[Address(RVA = "0x5F2A40", Offset = "0x5F1240", Length = "0x9E")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A87")]
	[Address(RVA = "0x5F2F70", Offset = "0x5F1770", Length = "0xDA")]
	public void StartUp()
	{
	}

	[Address(RVA = "0x5F2AE0", Offset = "0x5F12E0", Length = "0xB2")]
	[Token(Token = "0x6000A88")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000A89")]
	[Address(RVA = "0x5F2DE0", Offset = "0x5F15E0", Length = "0x111")]
	public void ShowBtn()
	{
	}

	[Address(RVA = "0x5F2F00", Offset = "0x5F1700", Length = "0x65")]
	[Token(Token = "0x6000A8A")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x36320", Offset = "0x35720")]
	private IEnumerator StartUpCoroutine()
	{
		return null;
	}

	[Address(RVA = "0x5F2D70", Offset = "0x5F1570", Length = "0x65")]
	[Token(Token = "0x6000A8B")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x36420", Offset = "0x35820")]
	private IEnumerator ShowBtnCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x5F2BA0", Offset = "0x5F13A0", Length = "0x1C9")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x5F3050", Offset = "0x5F1850", Length = "0x15")]
	public AutoFadeBtn()
	{
	}
}
