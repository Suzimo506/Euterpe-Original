using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001A1")]
public class WisadelSkillCounts : MonoBehaviour
{
	[Token(Token = "0x2000A4E")]
	private struct BombSign
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40036A5")]
		public GameObject bombRoot;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40036A6")]
		public GameObject bombOn;

		[Token(Token = "0x40036A7")]
		[FieldOffset(Offset = "0x10")]
		public GameObject bombOff;
	}

	[SerializeField]
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x18")]
	private Image m_ImgDetonate;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A43")]
	[SerializeField]
	private Transform m_PnlSkillCounts;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A44")]
	private GameObject m_ObjSkillCount;

	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x30")]
	private List<BombSign> m_SkillCountObjs;

	[Address(RVA = "0xD33A70", Offset = "0xD32270", Length = "0xA7")]
	[Token(Token = "0x6000BD5")]
	public void InitSkillHud()
	{
	}

	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0xD33C60", Offset = "0xD32460", Length = "0x1C7")]
	public void ShowSkillHud(Action onComplete)
	{
	}

	[Address(RVA = "0xD33BC0", Offset = "0xD323C0", Length = "0x9B")]
	[Token(Token = "0x6000BD7")]
	private void OnWisadelSkillOn()
	{
	}

	[Address(RVA = "0xD33800", Offset = "0xD32000", Length = "0x262")]
	[Token(Token = "0x6000BD8")]
	private void CreateHudElements()
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0xD33B20", Offset = "0xD32320", Length = "0x9D")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public WisadelSkillCounts()
	{
	}
}
