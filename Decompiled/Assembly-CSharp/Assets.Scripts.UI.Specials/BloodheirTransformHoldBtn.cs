using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x200086E")]
public class BloodheirTransformHoldBtn : SerializedMonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	[Token(Token = "0x4002C12")]
	[FieldOffset(Offset = "0x58")]
	private SkeletonGraphic m_SkeletonGraphic;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4002C13")]
	private Dictionary<string, string> m_Language2AnimationMapping;

	[Token(Token = "0x4002C14")]
	[FieldOffset(Offset = "0x68")]
	private float m_WaitTime;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4002C15")]
	private float m_HoldTime;

	[Token(Token = "0x4002C16")]
	[FieldOffset(Offset = "0x70")]
	private float m_WaitTimer;

	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4002C17")]
	private float m_HoldTimer;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002C18")]
	private bool m_IsWaiting;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002C19")]
	private Action m_OnStartHold;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002C1A")]
	private Action<bool> m_OnHoldFail;

	[Token(Token = "0x4002C1B")]
	[FieldOffset(Offset = "0x90")]
	private Action m_OnHoldSuccess;

	[Token(Token = "0x6004D13")]
	[Address(RVA = "0x60C160", Offset = "0x60A960", Length = "0x143")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x60C3A0", Offset = "0x60ABA0", Length = "0xBD")]
	[Token(Token = "0x6004D14")]
	private void Update()
	{
	}

	[Token(Token = "0x6004D15")]
	[Address(RVA = "0x60C100", Offset = "0x60A900", Length = "0x57")]
	public void Init(Action onStartHold, Action<bool> onHoldFail, Action onHoldSuccess)
	{
	}

	[Address(RVA = "0x60C2B0", Offset = "0x60AAB0", Length = "0x60")]
	[Token(Token = "0x6004D16")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x60C320", Offset = "0x60AB20", Length = "0x7F")]
	[Token(Token = "0x6004D17")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6004D18")]
	[Address(RVA = "0x60C460", Offset = "0x60AC60", Length = "0x15")]
	public BloodheirTransformHoldBtn()
	{
	}
}
