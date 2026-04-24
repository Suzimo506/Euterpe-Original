using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Variables;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA0200", Offset = "0x9F600")]
[Token(Token = "0x20005F6")]
public class OnFancyScrollViewCellUpdate : Event
{
	[NonSerialized]
	[Token(Token = "0x40021B4")]
	[FieldOffset(Offset = "0x70")]
	public bool isInViewport;

	[Token(Token = "0x40021B5")]
	[FieldOffset(Offset = "0x78")]
	private Animator m_Animator;

	[Token(Token = "0x40021B6")]
	[FieldOffset(Offset = "0x80")]
	private int m_StoreHash;

	[Token(Token = "0x40021B7")]
	[FieldOffset(Offset = "0x88")]
	private VariableBehaviour m_Variables;

	[Token(Token = "0x1700056D")]
	public bool isPlaceHolder
	{
		[Address(RVA = "0x432400", Offset = "0x430C00", Length = "0x8")]
		[Token(Token = "0x6003A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x89A130", Offset = "0x898930", Length = "0x7")]
		[Token(Token = "0x6003A51")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700056E")]
	public float animPos
	{
		[Address(RVA = "0x97FCF0", Offset = "0x97E4F0", Length = "0x9")]
		[Token(Token = "0x6003A52")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		[Token(Token = "0x6003A53")]
		[Address(RVA = "0x97FDA0", Offset = "0x97E5A0", Length = "0x9")]
		private set
		{
		}
	}

	[Token(Token = "0x1400004D")]
	public event Action<int> onDataIndexChanged
	{
		[Address(RVA = "0x97FC50", Offset = "0x97E450", Length = "0x9E")]
		[Token(Token = "0x6003A4E")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x97FD00", Offset = "0x97E500", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6003A4F")]
		remove
		{
		}
	}

	[Token(Token = "0x6003A54")]
	[Address(RVA = "0x97F7D0", Offset = "0x97DFD0", Length = "0x3C")]
	public int GetDataIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6003A55")]
	[Address(RVA = "0x97F9F0", Offset = "0x97E1F0", Length = "0x74")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003A56")]
	[Address(RVA = "0x97FBE0", Offset = "0x97E3E0", Length = "0x67")]
	public void UpdatePosition(int animHash, float position)
	{
	}

	[Address(RVA = "0x97FA70", Offset = "0x97E270", Length = "0x163")]
	[Token(Token = "0x6003A57")]
	public void UpdateData(int dataIndex)
	{
	}

	[Address(RVA = "0x4707E0", Offset = "0x46EFE0", Length = "0x2D")]
	[Token(Token = "0x6003A58")]
	public void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6003A59")]
	[Address(RVA = "0x97F810", Offset = "0x97E010", Length = "0x23")]
	public bool GetVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6003A5A")]
	[Address(RVA = "0x97F840", Offset = "0x97E040", Length = "0x1A5")]
	public void Init()
	{
	}

	[Address(RVA = "0x97F310", Offset = "0x97DB10", Length = "0x7")]
	[Token(Token = "0x6003A5B")]
	public OnFancyScrollViewCellUpdate()
	{
	}
}
