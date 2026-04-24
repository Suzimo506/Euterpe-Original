using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x200096D")]
public class PnlRoleTglControl : PnlRoleSelectedItem
{
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40033BF")]
	private Dictionary<Toggle, GameObject> m_TglToPnlMapping;

	[SerializeField]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40033C0")]
	private RectTransform m_ImgSelecTransform;

	[SerializeField]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40033C1")]
	private Toggle m_TglDefault;

	[Token(Token = "0x40033C2")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<Toggle, int> m_TglToIndexMapping;

	[Token(Token = "0x40033C3")]
	[FieldOffset(Offset = "0xA0")]
	public Action onChangeTgl;

	[Token(Token = "0x40033C4")]
	[FieldOffset(Offset = "0xA8")]
	private List<Toggle> m_TglList;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40033C5")]
	private int m_CurIndex;

	[Token(Token = "0x600560A")]
	[Address(RVA = "0x643EB0", Offset = "0x6426B0", Length = "0x480")]
	private void Awake()
	{
	}

	[Token(Token = "0x600560B")]
	[Address(RVA = "0x644460", Offset = "0x642C60", Length = "0xA9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600560C")]
	[Address(RVA = "0x644510", Offset = "0x642D10", Length = "0xE6")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x644640", Offset = "0x642E40", Length = "0x90")]
	[Token(Token = "0x600560D")]
	private void SelectTgl(Toggle tgl)
	{
	}

	[Address(RVA = "0x6446E0", Offset = "0x642EE0", Length = "0xA9")]
	[Token(Token = "0x600560E")]
	private void ShowSelect(RectTransform transform)
	{
	}

	[Address(RVA = "0x6448D0", Offset = "0x6430D0", Length = "0xC8")]
	[Token(Token = "0x600560F")]
	public void TurnLeft()
	{
	}

	[Address(RVA = "0x6449A0", Offset = "0x6431A0", Length = "0xD6")]
	[Token(Token = "0x6005610")]
	public void TurnRight()
	{
	}

	[Token(Token = "0x6005611")]
	[Address(RVA = "0x644790", Offset = "0x642F90", Length = "0x130")]
	private void TurnByAxis(float value)
	{
	}

	[Address(RVA = "0x644600", Offset = "0x642E00", Length = "0x32")]
	[Token(Token = "0x6005612")]
	public override void OnSelected()
	{
	}

	[Address(RVA = "0x644420", Offset = "0x642C20", Length = "0x32")]
	[Token(Token = "0x6005613")]
	public override void OnDeselected()
	{
	}

	[Address(RVA = "0x644340", Offset = "0x642B40", Length = "0xDF")]
	[Token(Token = "0x6005614")]
	private void OnChangeToNavigation(bool value)
	{
	}

	[Token(Token = "0x6005615")]
	[Address(RVA = "0x644A80", Offset = "0x643280", Length = "0x9C")]
	public PnlRoleTglControl()
	{
	}
}
