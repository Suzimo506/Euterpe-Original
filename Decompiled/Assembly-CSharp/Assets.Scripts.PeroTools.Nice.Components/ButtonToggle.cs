using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Components;

[Token(Token = "0x2000606")]
public class ButtonToggle : SerializedMonoBehaviour
{
	[Token(Token = "0x40021D4")]
	[FieldOffset(Offset = "0x58")]
	public ToggleGroup group;

	[Token(Token = "0x40021D5")]
	[FieldOffset(Offset = "0x60")]
	public Button btnPre;

	[Token(Token = "0x40021D6")]
	[FieldOffset(Offset = "0x68")]
	public Button btnNext;

	[Token(Token = "0x40021D7")]
	[FieldOffset(Offset = "0x70")]
	public AudioClip clickSfx;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40021D8")]
	public Text levelDesigner;

	[Token(Token = "0x40021D9")]
	[FieldOffset(Offset = "0x80")]
	public GameObject masterLockImg;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40021DA")]
	public GameObject masterLevelImg;

	[Token(Token = "0x40021DB")]
	[FieldOffset(Offset = "0x90")]
	public bool isLoop;

	[Token(Token = "0x40021DC")]
	[FieldOffset(Offset = "0x94")]
	private int m_Index;

	[Token(Token = "0x40021DD")]
	[FieldOffset(Offset = "0x98")]
	public List<Toggle> toggles;

	[Token(Token = "0x40021DE")]
	[FieldOffset(Offset = "0xA0")]
	public List<Text> texts;

	[Token(Token = "0x1400004E")]
	public event Action onDifficultyChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x73B1C0", Offset = "0x7399C0", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6003AB1")]
		[CompilerGenerated]
		[Address(RVA = "0x73B260", Offset = "0x739A60", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x6003AB2")]
	[Address(RVA = "0x73A270", Offset = "0x738A70", Length = "0x231")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003AB3")]
	[Address(RVA = "0x73A8A0", Offset = "0x7390A0", Length = "0x31C")]
	private void OnToggleValueChanged(Toggle tgl, bool state)
	{
	}

	[Address(RVA = "0x73ABC0", Offset = "0x7393C0", Length = "0x5D7")]
	[Token(Token = "0x6003AB4")]
	private void ToggleDiff()
	{
	}

	[Token(Token = "0x6003AB5")]
	[Address(RVA = "0x73A710", Offset = "0x738F10", Length = "0x18B")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6003AB6")]
	[Address(RVA = "0x73A4B0", Offset = "0x738CB0", Length = "0x25F")]
	private void OnClick(bool pre)
	{
	}

	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	[Token(Token = "0x6003AB7")]
	public ButtonToggle()
	{
	}
}
