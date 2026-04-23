using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A9")]
public class TutorialEvaluateItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x18")]
	private Button m_BtnEnter;

	[Token(Token = "0x4000A59")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_DisableGameObjects;

	[SerializeField]
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> m_EnableGameObjects;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000A5B")]
	private Button m_BtnStopAnimation;

	[SerializeField]
	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x38")]
	private DOTweenAnimation m_DOTweenAnimation;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A5D")]
	private float m_DelayTime;

	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000A5E")]
	private bool m_IsJump;

	[Address(RVA = "0x520050", Offset = "0x51E850", Length = "0x99")]
	[Token(Token = "0x6000BF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x520210", Offset = "0x51EA10", Length = "0x155")]
	private void Start()
	{
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x51FF40", Offset = "0x51E740", Length = "0x10F")]
	private void OnDisableAndEnableObjs()
	{
	}

	[Address(RVA = "0x5200F0", Offset = "0x51E8F0", Length = "0x115")]
	[Token(Token = "0x6000BF7")]
	private void OnJumpScene()
	{
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x520650", Offset = "0x51EE50", Length = "0xE")]
	public TutorialEvaluateItem()
	{
	}
}
