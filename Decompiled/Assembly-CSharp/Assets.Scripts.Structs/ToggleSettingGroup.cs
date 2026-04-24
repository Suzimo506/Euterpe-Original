using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Structs;

[Serializable]
[Token(Token = "0x200058E")]
public class ToggleSettingGroup
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40020B9")]
	[SerializeField]
	private ToggleGroup m_ToggleGroup;

	[Token(Token = "0x40020BA")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private List<Toggle> m_Toggles;

	[Token(Token = "0x17000528")]
	public List<Toggle> Toggles
	{
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003895")]
	[Address(RVA = "0x6606D0", Offset = "0x65EED0", Length = "0x124")]
	public void Init()
	{
	}

	[Address(RVA = "0x660800", Offset = "0x65F000", Length = "0x1AE")]
	[Token(Token = "0x6003896")]
	public void SetCallback(Action<int, bool> tglCallback)
	{
	}

	[Token(Token = "0x6003897")]
	[Address(RVA = "0x660630", Offset = "0x65EE30", Length = "0x95")]
	public bool GetCheck(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6003898")]
	[Address(RVA = "0x6609B0", Offset = "0x65F1B0", Length = "0xBA")]
	public void SetCheck(int index, bool isOn, bool sendEvent)
	{
	}

	[Token(Token = "0x6003899")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ToggleSettingGroup()
	{
	}
}
