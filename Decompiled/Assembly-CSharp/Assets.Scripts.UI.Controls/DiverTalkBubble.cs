using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B4")]
public class DiverTalkBubble : BaseTalkBubble
{
	[Serializable]
	[Token(Token = "0x2000D4D")]
	public class CharacterDefine
	{
		[Token(Token = "0x4003F4A")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_CharacterNameObj;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003F4B")]
		public Sprite m_CharacterBubbleType;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003F4C")]
		public Sprite m_CharacterStarType;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003F4D")]
		public Sprite m_CharaceterShellType;

		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003F4E")]
		public Color m_CharacterShadowType;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6006410")]
		public CharacterDefine()
		{
		}
	}

	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002D70")]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002D71")]
	private Image m_ImgBase;

	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4002D72")]
	private Shadow m_TxtShadow;

	[SerializeField]
	[Token(Token = "0x4002D73")]
	[FieldOffset(Offset = "0x78")]
	private Image m_ImgStar;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002D74")]
	[SerializeField]
	private Image m_ImgShell;

	[SerializeField]
	[Token(Token = "0x4002D75")]
	[FieldOffset(Offset = "0x88")]
	private List<List<float>> m_TalkDurationsList;

	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4002D76")]
	private List<CharacterDefine> m_CharacterDefineList;

	[Token(Token = "0x4002D77")]
	[FieldOffset(Offset = "0x98")]
	private Coroutine m_Coroutine;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4002D78")]
	private string[] m_TalkList;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4002D79")]
	private int m_TalkIndex;

	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4002D7A")]
	private int m_SentenceIndex;

	[Token(Token = "0x4002D7B")]
	[FieldOffset(Offset = "0xB0")]
	private int m_CharacterIndex;

	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4002D7C")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4002D7D")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsShowing;

	[Token(Token = "0x6004EB7")]
	[Address(RVA = "0x5AC9E0", Offset = "0x5AB1E0", Length = "0x45")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5ACE30", Offset = "0x5AB630", Length = "0x8A")]
	[Token(Token = "0x6004EB8")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x5ACD90", Offset = "0x5AB590", Length = "0x9D")]
	[Token(Token = "0x6004EB9")]
	public override void EndTalk()
	{
	}

	[Token(Token = "0x6004EBA")]
	[Address(RVA = "0x5A7AC0", Offset = "0x5A62C0", Length = "0x9")]
	public override float GetEndTime()
	{
		return default(float);
	}

	[Address(RVA = "0x5ACEC0", Offset = "0x5AB6C0", Length = "0x212")]
	[Token(Token = "0x6004EBB")]
	public override void SetTalkTxt(string txt)
	{
	}

	[Address(RVA = "0x5ACA30", Offset = "0x5AB230", Length = "0xD1")]
	[Token(Token = "0x6004EBC")]
	private void BubbleIn()
	{
	}

	[Address(RVA = "0x5ACB10", Offset = "0x5AB310", Length = "0x4B")]
	[Token(Token = "0x6004EBD")]
	private void BubbleOut()
	{
	}

	[Address(RVA = "0x5AD0E0", Offset = "0x5AB8E0", Length = "0x65")]
	[Token(Token = "0x6004EBE")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x441C0", Offset = "0x435C0")]
	private IEnumerator ShowCurTalk()
	{
		return null;
	}

	[Token(Token = "0x6004EBF")]
	[Address(RVA = "0x5ACB60", Offset = "0x5AB360", Length = "0x222")]
	private void ChangeCharacter(int index)
	{
	}

	[Token(Token = "0x6004EC0")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	public DiverTalkBubble()
	{
	}
}
