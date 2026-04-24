using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlRole;

[Token(Token = "0x2000966")]
public class PnlRoleNavigationTglControl : PnlRoleSelectedItem
{
	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400336E")]
	private Dictionary<Toggle, string> m_ToggleToCharacterTypeMapping;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400336F")]
	[SerializeField]
	private PnlRoleNavigationView m_NavigationView;

	[Token(Token = "0x4003370")]
	private static int m_CurIndex;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4003371")]
	private List<Toggle> m_TglList;

	[Address(RVA = "0x63B430", Offset = "0x639C30", Length = "0x4B6")]
	[Token(Token = "0x60055A2")]
	private void Awake()
	{
	}

	[Token(Token = "0x60055A3")]
	[Address(RVA = "0x63B8F0", Offset = "0x63A0F0", Length = "0x125")]
	private void InitRedotState(KeyValuePair<Toggle, string> pair)
	{
	}

	[Address(RVA = "0x63BA20", Offset = "0x63A220", Length = "0x82")]
	[Token(Token = "0x60055A4")]
	private void TurnLeft()
	{
	}

	[Token(Token = "0x60055A5")]
	[Address(RVA = "0x63BAB0", Offset = "0x63A2B0", Length = "0x88")]
	private void TurnRight()
	{
	}

	[Address(RVA = "0x63BB40", Offset = "0x63A340", Length = "0x6C")]
	[Token(Token = "0x60055A6")]
	public PnlRoleNavigationTglControl()
	{
	}
}
