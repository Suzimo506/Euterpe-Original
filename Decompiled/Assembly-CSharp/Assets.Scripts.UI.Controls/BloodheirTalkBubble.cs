using Cpp2ILInjected;
using MEC;
using UnityEngine;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B2")]
public class BloodheirTalkBubble : BaseTalkBubble
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002D6A")]
	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x4002D6B")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsShowing;

	[Token(Token = "0x4002D6C")]
	[FieldOffset(Offset = "0x6C")]
	private CoroutineHandle m_Coroutine;

	[Token(Token = "0x4002D6D")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 m_StartPos;

	[Token(Token = "0x6004EAB")]
	[Address(RVA = "0x5A79E0", Offset = "0x5A61E0", Length = "0x3F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004EAC")]
	[Address(RVA = "0x5A7AD0", Offset = "0x5A62D0", Length = "0x51")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004EAD")]
	[Address(RVA = "0x5A7A20", Offset = "0x5A6220", Length = "0x9C")]
	public override void EndTalk()
	{
	}

	[Token(Token = "0x6004EAE")]
	[Address(RVA = "0x5A7AC0", Offset = "0x5A62C0", Length = "0x9")]
	public override float GetEndTime()
	{
		return default(float);
	}

	[Token(Token = "0x6004EAF")]
	[Address(RVA = "0x5A7B30", Offset = "0x5A6330", Length = "0x14B")]
	public override void SetTalkTxt(string txt)
	{
	}

	[Token(Token = "0x6004EB0")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public BloodheirTalkBubble()
	{
	}
}
