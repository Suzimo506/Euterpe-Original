using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200017C")]
public class FoolishAdvertiseGenerator : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_AdvertiseList;

	[SerializeField]
	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x20")]
	private CanvasGroup m_CanvasGroup;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400096A")]
	private Dictionary<string, FoolishAdvertiseController> m_AdvertiseObjs;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400096B")]
	private FoolishAdvertiseController m_ActiveAdvertise;

	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x38")]
	private DateTime m_StartTime;

	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x40")]
	private DateTime m_EndTime;

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x44EEC0", Offset = "0x44D6C0", Length = "0x209")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x44F0D0", Offset = "0x44D8D0", Length = "0x69")]
	[Token(Token = "0x6000AEB")]
	public void SetAdvertiseActive(bool value)
	{
	}

	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x44F140", Offset = "0x44D940", Length = "0xE0")]
	public FoolishAdvertiseGenerator()
	{
	}
}
