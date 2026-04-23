using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000135")]
public class PointsBar : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000799")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fancyScrollView;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400079A")]
	private List<Animator> m_BarAnim;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400079B")]
	private int m_AnimHash;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400079C")]
	private int m_CurrentPoint;

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x5693C0", Offset = "0x567BC0", Length = "0x181")]
	private void Awake()
	{
	}

	[Address(RVA = "0x569570", Offset = "0x567D70", Length = "0xA6")]
	[Token(Token = "0x60008BE")]
	private void FsvIntemIndexChange(int index)
	{
	}

	[Address(RVA = "0x569950", Offset = "0x568150", Length = "0x2D")]
	[Token(Token = "0x60008BF")]
	public void SetDefaultPoint(int index)
	{
	}

	[Address(RVA = "0x569620", Offset = "0x567E20", Length = "0x1BD")]
	[Token(Token = "0x60008C0")]
	private void FsvOnOnUpdatePosition(float pos)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x5697E0", Offset = "0x567FE0", Length = "0x83")]
	private int LoopCell(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x569550", Offset = "0x567D50", Length = "0x1E")]
	private float CheckDis(float dis)
	{
		return default(float);
	}

	[Address(RVA = "0x569870", Offset = "0x568070", Length = "0xAC")]
	[Token(Token = "0x60008C3")]
	private void PlayAnim(int index, float pos)
	{
	}

	[Address(RVA = "0x569920", Offset = "0x568120", Length = "0x2A")]
	[Token(Token = "0x60008C4")]
	public void SetCurrentPoint(bool enable)
	{
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x569980", Offset = "0x568180", Length = "0x69")]
	public PointsBar()
	{
	}
}
